/*
* Access_Control_System.c
*
* Created: 2020-03-10 오후 5:25:41
* Author : kccistc
*/

/*
결선방법

RFID-RC522  ATMEGA128A
SDA  ----- PORTB.0   // 슬레이브 선택
SCK  ----- PORTB.1   // 시리얼클럭
MOSI ----- PORTB.2   // 마스터 --> 슬레이브
MISO ----- PORTB.3   // 슬레이브-->마스터
IRQ  ----- 연결안함
GND  ----- GND
RST  ----- +3.3V
VCC  ----- +3.3v
*/

#define F_CPU 16000000UL

#include <avr/io.h>
#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#include <util/delay.h>
#include <avr/interrupt.h>

#include "uart0.h"
#include "Timer.h"
#include "mfrc522.h"
#include "spi.h"

volatile int normal_mode_state = 1;
volatile int management_mode_state = 0;
volatile int join_mode_state = 0;

#define ON		1
#define OFF		0

FILE OUTPUT = FDEV_SETUP_STREAM(uart0_transmit, NULL, _FDEV_SETUP_WRITE);
FILE INPUT = FDEV_SETUP_STREAM(NULL, uart0_receive, _FDEV_SETUP_READ);

ISR(USART0_RX_vect) {
	uart0_ISR_receive();
}

void pwm_init(void)
{
	// 모드 14, 고속 PWM 모드
	TCCR1A |= (1 << WGM11);
	TCCR1B |= (1 << WGM12) | (1 << WGM13);
	
	// 비반전 모드
	// TOP : ICR1, 비교일치값 : OCR1A, OCR1B 레지스터
	TCCR1A |= (1 << COM1A1) | (1 << COM1B1);
	
	TCCR1B |= (1 << CS11);		// 분주율 8, 2MHz
	ICR1 = 39999;				// 20ms 주기
}

void setup() {
	spi_init();
	mfrc522_init();
	uart0_init();
	pwm_init();
	sei();
}

void port_init() {
	DDRA = 0x08;	// Buzzer
}

int main(void)
{
	uint8_t *receiveData;
	uint8_t byte;
	uint8_t str[MAX_LEN];

	stdout = &OUTPUT;   // File pointer 2
	stdin = &INPUT;     // File pointer 0
	
	setup();
	port_init();
	
	while (1)
	{
		if(isRxString()) {
			receiveData = getRxString();
			if(strncmp(receiveData, "management_mode_on", sizeof("management_mode_on")) == 0) {
				normal_mode_state = OFF;
				join_mode_state = ON;
			}
			if(strncmp(receiveData, "management_mode_off", sizeof("management_mode_off")) == 0) {
				normal_mode_state = ON;
				join_mode_state = OFF;
			}
		}
		
		// 평상시 동작 모드 (서보모터 ON)
		if(normal_mode_state == ON) {
			byte = mfrc522_request(PICC_REQALL,str);
			
			if (byte == CARD_FOUND)	{
				char buffer[10];
				
				// RFID Card Serial Number --> byte 변수에 저장
				for (int i=0; i < MAX_LEN; i++) {
					str[i] = ' ';
				}
				byte = mfrc522_get_card_serial(str);
				
				// Buzzer Sound
				PORTA |= 0x08;
				_delay_ms(100);
				PORTA &= ~0x08;
				
				// RFID Card Serial Number 출력
				for (int i=0; i < 5; i++) {
					sprintf(buffer, "%02x ", str[i]);
					uart0_print_string(buffer);
				}
				uart0_print_string("\n");
				
				// 서보모터
			}
			_delay_ms(1000);
		}
		// RFID Card 등록 모드 (서보모터 OFF)
		else if(management_mode_state == ON) {
			byte = mfrc522_request(PICC_REQALL,str);
			
			if (byte == CARD_FOUND)	{
				char buffer[10];
				
				// RFID Card Serial Number --> byte 변수에 저장
				for (int i=0; i < MAX_LEN; i++) {
					str[i] = ' ';
				}
				byte = mfrc522_get_card_serial(str);
				
				// Buzzer Sound
				for(int i = 0; i < 2; i++) {
					PORTA |= 0x08;
					_delay_ms(100);
					PORTA &= ~0x08;
					_delay_ms(100);
				}
				
				// RFID Card Serial Number 출력
				for (int i=0; i < 5; i++) {
					sprintf(buffer, "%02x ", str[i]);
					uart0_print_string(buffer);
				}
				uart0_print_string("\n");
			}
			_delay_ms(1000);
		}
	}
}


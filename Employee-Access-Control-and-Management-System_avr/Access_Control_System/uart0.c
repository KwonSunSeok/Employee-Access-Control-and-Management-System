/*
* uart0.c
*
* Created: 2020-01-09 오전 11:22:37
*  Author: Kwon Sun Seok
*/

#define F_CPU 16000000UL
#include <avr/io.h>
#include <util/delay.h>

volatile uint8_t rxString[64] = {0};
volatile uint8_t rxReadyFlag = 0;

void uart0_init(void) {
	/* Set baud rate */
	UBRR0H = 0;
	UBRR0L = 207;   // 9600 bps 모드로 설정
	
	// 비동기, 8비트 데이터, 패리티 없음, 1비트 정지 비트 모드
	UCSR0A |= (1 << U2X0);
	UCSR0C |= 0x06;
	UCSR0B = (1<<RXEN0) | (1<<TXEN0) | (1<<RXCIE0);  // Receive, Transmit 가능 및 Receive Complete Interrupt Enable
}

void uart0_transmit(char data) {
	while( !(UCSR0A & (1 << UDRE0)) );	// 송신 가능 대기
	UDR0 = data;						// 데이터 전송
}

unsigned char uart0_receive(void) {
	while( !(UCSR0A & (1 << RXC0)) );	// 데이터 수신 대기
	return UDR0;
}

void uart0_print_string(char *str) {	// 문자열 송신
	for(int i = 0; str[i]; i++)			// '\0'문자를 만날 때까지 반복
	uart0_transmit(str[i]);				// 바이트 단위 출력
}

void uart0_ISR_receive() {
	static uint8_t head=0;
	volatile uint8_t data;
	
	data = UDR0;
	if (data == '\n' || data == '\r')
	{
		rxString[head] = '\0';
		head=0;
		rxReadyFlag = 1;
	}
	else
	{
		rxString[head] = data;
		head++;
	}
}

uint8_t isRxD() {
	return (UCSR0A & (1<<7));
}

uint8_t isRxString() {
	return rxReadyFlag;
}

uint8_t* getRxString() {
	rxReadyFlag = 0;
	return rxString;
}
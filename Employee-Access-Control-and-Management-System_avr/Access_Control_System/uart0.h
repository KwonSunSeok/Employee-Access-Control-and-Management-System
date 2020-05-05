/*
 * uart0.h
 *
 * Created: 2020-01-09 오전 11:22:54
 *  Author: Kwon Sun Seok
 */

#ifndef UART0_H_
#define UART0_H_

#define F_CPU 16000000UL
#include <avr/io.h>

void uart0_init(void);
void uart0_transmit(char data);
void uart0_ISR_receive();
unsigned char uart0_receive(void);
void uart0_print_string(char *str);

uint8_t isRxD();
uint8_t isRxString();
uint8_t* getRxString();

#endif /* UART0_H_ */
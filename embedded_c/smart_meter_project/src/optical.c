#include "optical.h"
#include "stm32f1xx_hal.h" // Adjust for your MCU
#include <stdio.h>
#include <string.h>



// Example UART for optical communication
extern UART_HandleTypeDef huart1;

void optical_task(void *argument) {
    while (1) {
        if (!optical_probe_connected()) {
           
            HAL_Delay(100);
            continue;
        }
        
    }
}

int optical_send_snapshot(void) {
    return send_json_snapshot();
}

int optical_send_param(const char *key) {
    return send_param_value(key);
}

bool optical_process_one_command(uint32_t timeout_ms) {
    return process_command(timeout_ms);
}

static void optical_handshake(void) {
    uint8_t handshake_byte = 0xA5;
    uint8_t response = 0;
    HAL_UART_Transmit(&huart1, &handshake_byte, 1, 100);
    HAL_UART_Receive(&huart1, &response, 1, 100);
    
}

static void optical_request_response(void) {
    
    uint8_t request = 0x01; 
    uint8_t response[16] = {0};
    HAL_UART_Transmit(&huart1, &request, 1, 100);
    HAL_UART_Receive(&huart1, response, sizeof(response), 500);
  
}

int optical_send_param(const char *key){
    uint8_t response[32] = {0};

}


#include "gps.h"

#include <stdint.h>
#include <stdio.h>
#include <string.h>
#include "stm32f1xx_hal.h" // Adjust according to your STM32 series


#define LOG_FILE_PATH "C:\\Logs\\gps.txt" 


extern UART_HandleTypeDef huart2; // Assuming huart2 is defined and initialized elsewhere


void gps_init(void){

    HAL_UART_Transmit(&huart2, (uint8_t *)"GPS INIT\r\n", 10, 100); // Example command to initialize GPS module
}


bool gps_getdata(gps_data_t *data ){
    char gps_buff[128] = {0};

    if(HAL_UART_Receive(&huart2, (uint8_t *)gps_buff, sizeof(gps_buff)-1, 1000) != HAL_OK){
        return false; // Timeout or error
    }
    
    strcpy(gps_buff , "$GPGGA,123519,4807.038,N,01131.000,E,1,08,0.9,545.4,M,46.9,M,,*47");


    if(strlen(gps_buff) > 0){
        data->latitude = 48.1173; // Example latitude
        data->longitude = 11.5167; // Example longitude
        return true;
    }
    if(strlen(gps_buff) == 0){
        return false;
    }
   

}
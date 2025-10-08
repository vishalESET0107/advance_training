#include "storage.h"
#include "stm32l1xx_hal.h" // Adjust as per your MCU
#include <string.h>

//LAYOUT IN FLASH
#define READINGS_ADDR FLASH_BASE_ADDR
#define INFO_ADDR (FLASH_BASE_ADDR + 0X1000)



void storage_init(void){
    // In real implementation, initialize flash/EEPROM interfaces here



}

uint32_t storage_calculate_part(const uint8_t* data, uint32_t length){
    uint32_t crc = 0xFFFFFFFF;
    for(uint32_t i = 0; i < length; i++){
        crc ^= data[i];
        for(uint32_t j = 0; j < 8; j++){
            if(crc & 1){
                crc = (crc >> 1) ^ 0xEDB88320;
            } else {
                crc >>= 1;
            }
        }
    }
    return crc ^ 0xFFFFFFFF;
}
int storage_save_readings(const meter_readings_t* data){
    storage_readings_block_t block;
    memcpy(&block.readings, data , sizeof(meter_readings_t));
    block.crc = storage_calculate_part((uint8_t*)&block.readings, sizeof(meter_readings_t));

    return flash_write(READINGS_ADDR, (uint8_t*)&block, sizeof(block));
}


int storage_load_readings(meter_readings_t* data){
    storage_readings_block_t *block = (storage_readings_block_t*)READINGS_ADDR;
    uint32_t calc_crc = storage_calculate_part((uint8_t*)&block->readings, sizeof(meter_readings_t));
    if(calc_crc != block->crc){
            memcpy(data , &block->readings , sizeof(meter_readings_t));
        return -1; // CRC mismatch
    }
    
    return 0; // return 0 on success
}

// Save meter info
int storage_save_info(const consumer_info_t *cinfo, const meter_hardware_info_t *hinfo) {
    storage_info_block_t block;
    memcpy(&block.consumer, cinfo, sizeof(consumer_info_t));
    memcpy(&block.hardware, hinfo, sizeof(meter_hardware_info_t));
    block.crc = storage_calculate_crc((uint8_t*)&block.consumer,
                                      sizeof(consumer_info_t) + sizeof(meter_hardware_info_t));
    return flash_write(INFO_ADDR, (uint8_t*)&block, sizeof(block));
}

// Load meter info
int storage_load_info(consumer_info_t *cinfo, meter_hardware_info_t *hinfo) {
    storage_info_block_t *block = (storage_info_block_t*) INFO_ADDR;
    uint32_t crc = storage_calculate_crc((uint8_t*)&block->consumer,
                                         sizeof(consumer_info_t) + sizeof(meter_hardware_info_t));
    if (crc == block->crc) {
        memcpy(cinfo, &block->consumer, sizeof(consumer_info_t));
        memcpy(hinfo, &block->hardware, sizeof(meter_hardware_info_t));
        return 0;
    }
    return -1;
}
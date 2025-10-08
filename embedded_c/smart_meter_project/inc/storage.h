#ifndef STORAGE H 
#define STORAGE_H

#include <stdint.h>
#include "Meter_Readings.h"
#include "Meter_Info.h"
// Storage addresses in Flash (adjust as per MCU memory map)
#define FLASH_BASE_ADDR 0x08060000U // example flash sector

#define STORAGE_SIZE 0x2000 // 8 kb allocated


// Data blocks
typedef struct {
    meter_readings_t readings;
    uint32_t crc;
} storage_readings_block_t;

typedef struct {
    consumer_info_t consumer;
    meter_hardware_info_t hardware;
    uint32_t crc;
} storage_info_block_t;


//api
void storage_init(void);
int storage_save_readings(const meter_readings_t  *data);
int storage_load_readings(meter_readings_t * data);

int storage_save_info(const consumer_info_t *cinfo, const meter_hardware_info_t *hinfo);
int storage_load_info(consumer_info_t *cinfo, meter_hardware_info_t *hinfo);

//utility
uint32_t storage_calculate_part(const uint8_t *data, uint32_t length);

#endif
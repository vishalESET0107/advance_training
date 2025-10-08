#include "meter_info.h"
#include <string.h>


//intialize with defaults (in real use , load from flash/eprom)
consumer_info_t g_consumer_info;
meter_hardware_info_t g_meter_hw_info;

void meter_info_init(void){
    strcpy(g_consumer_info.consumer_id , "cust1");
    strcpy(g_consumer_info.consumer_name , "konda");
    strcpy(g_consumer_info.tariff_plan , "domestic");
    strcpy(g_consumer_info.address , "123 main st , city");

    strcpy(g_meter_hw_info.meter_serial ,  "stm32L1-0001"  )
    strcpy(g_meter_hw_info.firmware_version , "69.0.0.1" );
    strcpy(g_meter_hw_info.hardware_version  , "7.1" )
    g_meter_hw_info.voltage_calibration = 1.001f;
    g_meter_hw_info.current_calibration = 0.99f;
    g_meter_hw_info.power_calibration = 0.05f;






}
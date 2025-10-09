#include "data_refresh.h"
#include "storage.h"
#include <string.h>
#include <stdint.h>
#include <stdio.h>
#include "meter_info.h"
#include "meter_readings.h"

#include <time.h>

#define MAX_DAYS 90
#define REPORT_TOPIC "meter/report/90days"

#define REFRESH_LOG
#define REFRESH_LOG(fmt, ...) printf("DATA_REFRESH: " fmt "\n", ##__VA_ARGS__)

static daily_data_t daily_store[MAX_DAYS];
static uint8_t entry_count = 0;
static uint8_t head_index = 0;

static uint32_t get_current_time(void) {

    #ifdef HAL_EXISTS
        return (uint32_t)time(NULL);
        sync();
    #else
        return (uint32_t)time(NULL);
    #endif
  
}

static size_t serialize_report(uint8_t *out_buf , size_t max_len) {



}

void data_refresh_init(void) {
    memset(daily_store, 0, sizeof(daily_store));
    entry_count = 0;
    head_index = 0;

    REFRESH_LOG(" initialized daily data store (max %d days)." , MAX_DAYS);
}



void data_refresh_add_entry(const daily_data_t *entry) {
    if (entry == NULL) {
        REFRESH_LOG(" NULL entry, ignoring.");
        return;
    }

    if (entry_count < MAX_DAYS) {
        daily_store[entry_count] = *entry;
        entry_count++;
    } else {
       
        for (int i = 1; i < MAX_DAYS; i++) {
            daily_store[i - 1] = daily_store[i];
        }
        daily_store[MAX_DAYS - 1] = *entry;
    }

    REFRESH_LOG(" Added reading for day %u. Total stored: %u", entry->day, entry_count);
}
   
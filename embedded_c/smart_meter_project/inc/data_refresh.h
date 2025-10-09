#ifndef DATA_REFRESH_H
#define DATA_REFRESH_H

#include <stdint.h>
#include <stdef.h>

void data_refresh_init(void);

void data_refresh_add_reading(const daily_data_t* entry);

void data_refresh_send_report(void);

#endif 

#ifndef GPS_H
#define GPS_H

#include <stdint.h>
#include <stdbool.h>

typedef struct {
    float latitude ;
    float longitude;

} gps_data_t;

typedef struct {
    float latitude;
    float longitude; // e.g., "2023-10-05 14:30:00"
} gps_nvm_data_t;

void gps_init(void);

bool gps_getdata(gps_data_t *data);

#endif

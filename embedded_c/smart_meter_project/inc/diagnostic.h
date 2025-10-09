#ifndef TAMPER_DIAGNOSTIC_H
#define TAMPER_DIAGNOSTIC_H

#include <stdint.h>

typedef enum  {
    TAMPER_NONE = 0,
    TAMPER_MAGNETIC =1 ,
    TAMPER_COVER_OPEN =2,
    TAMPER _REVERSE_CURRENT = 3
} tamper_type_t;




void diagnostic_init(void);
void diagnostic_tamper_magnetic(tamper_type_t trigger);
void diagnostic_tamper_cover_open(tamper_type_t trigger);
void diagnostic_tamper_reverse_current(tamper_type_t trigger);

void tamper_moniter_init(uint32_t poll_interval_ms);

void tamper_moniter_poll (void);

int tamper_moniter_force_event(tamper_type_t code);


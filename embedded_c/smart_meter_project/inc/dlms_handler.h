#ifndef DLMS_HANDLER_H
#define DLMS_HANDLER_H

#include <stdint.h>

typedef enum {
    DLMS_GET,
    DLMS_SET,
    DLMS_ACTION,
    DLMS_READ,
    DLMS_WRITE,
    DLMS_UNKNOWN

} dlms_request_type_t;

typedef struct {
    dlms_request_type_t type;
    uint32_t obis_code;
    uint8_t *payload;
    uint16_t length;
}dlms_request_t;

typedef struct {
   uint8_t data[256];
    uint16_t length;
} dlms_response_t;

void dlms_handler_init(void);

int dlms_process_request(const dlms_request_t *req, dlms_response_t *resp);

bool DLMS_DecryptRequest(const uint8_t *input , size_t input_len, uint8_t *output, size_t max_output_len);

void encrypt_response(uint8_t *data, uint16_t length);

void decrypt_response(uint8_t *data, uint16_t length);

void DLMS_ProcessAPDU(uint8_t *apdu, uint16_t apdu_len);

void DLMS_Receive_handler(const uint8_t *payload, uint16_t length);

void send_response(const uint8_t *data, uint16_t length);

#endif                                                                                                                                                                                              



#include "dlms_handler.h"
#include "stm32f1xx_hal.h" // Adjust for your MCU
#include <string.h>







#include <stdint.h>




void dlms_handler_init(void) {
   
}

  

int dlms_process_request(const dlms_request_t *req, dlms_response_t *resp) {
    if (!req || !resp) {
        return -1;

    }

   
    switch (req->type) {
        case DLMS_GET:
         

            resp->length = snprintf((char *)resp->data, sizeof(resp->data), "GET OBIS: %u", req->obis_code);
            break;
        case DLMS_SET:
           
            resp->length = snprintf((char *)resp->data, sizeof(resp->data), "SET OBIS: %u", req->obis_code);
            break;
        case DLMS_ACTION:
            
            resp->length = snprintf((char *)resp->data, sizeof(resp->data), "ACTION OBIS: %u", req->obis_code);
            break;
        case DLMS_READ:
          
            resp->length = snprintf((char *)resp->data, sizeof(resp->data), "READ OBIS: %u", req->obis_code);
            break;
        case DLMS_WRITE:
          
            resp->length = snprintf((char *)resp->data, sizeof(resp->data), "WRITE OBIS: %u", req->obis_code);
            break;
        default:
            resp->length = snprintf((char *)resp->data, sizeof(resp->data), "UNKNOWN REQUEST");
            return -2;
    }

    return 0;  
}
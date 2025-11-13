/*#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include "iot.h"

int main(){
    init_meter();
    Obiscode* obiscode = (Obiscode*)malloc(sizeof(Obiscode));
    
    printf("Obiscode: %d.%d.%d.%d.%d.%d\n",obiscode->a,obiscode->b,obiscode->c,obiscode->d,obiscode->e,obiscode->f);
    make_obiscode(obiscode,1,1,1,1,1,1);
    printf("Obiscode: %d.%d.%d.%d.%d.%d\n",obiscode->a,obiscode->b,obiscode->c,obiscode->d,obiscode->e,obiscode->f);


    Cosemobject *cosem = (Cosemobject*)malloc(sizeof(Cosemobject));
    cosem->code = obiscode;

    get_cosemobject_info(cosem,obiscode);
    if(cosem != NULL){
        printf("Cosemobject data: %d\n",cosem->data);   
    } 
    else {
        printf("Cosemobject not found\n");
    }

}*/

#include<stdio.h>
#include "iot.h"
#include<stdlib.h>

int main(){
    init_meter();
    ObisCode* obisCode = (ObisCode*)malloc(sizeof(ObisCode));
    make_obis_code(obisCode, 1,1,1,1,1,3);
    printf("obis code-> %d.%d.%d.%d.%d.%d\n\n\n", obisCode->a,obisCode->b,obisCode->c,obisCode->d,obisCode->e,obisCode->f);
    
    
    CosemObject *cosem = (CosemObject*) malloc(sizeof(CosemObject));
    
    get_cosem_object(cosem, obisCode);
    if (cosem != NULL){
        printf("cosem->value: %f",cosem->data);
    }else{
        printf("cosem object was null");
    }
    // print_cosem_objects();

}


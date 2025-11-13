/*#include "iot.h"
#include <stdlib.h>
#include <stdio.h>

#define MAX_OBJECTS 3


Cosemobject *objects;

void make_obiscode(Obiscode *code, int a, int b, int c, int d, int e, int f) {
      
   code->a = a;
    code->b = b;
    code->c = c;
    code->d = d;
    code->e = e;
    code->f = f;
}

void make_cosemobject(Cosemobject* obj, Obiscode* code, int data) {
    obj->code = code;
    obj->data = data;
}

void get_cosemobject_info(Cosemobject* obj, Obiscode* code) {
     for(int i=0; i<3; i++)
      {
        if(compare_obiscode(objects[i].code, code)) {
           
            obj->data = objects[i].data;
            return;
        }
      }
       
}

void init_meter() {

    // Cosemobject temp_objects[] = {
    //     {{1,0,1,8,0,255}, 12345},
    //     {{1,0,2,8,0,255}, 67890},
    //     {{1,0,3,8,0,255}, 13579}
    // };

    for(int i=0; i<MAX_OBJECTS; i++)
    {
        objects = (Cosemobject*)malloc(MAX_OBJECTS * sizeof(Cosemobject));
         Obiscode obis= {1,1,1,1,1,i};
        Cosemobject object = {&obis, 3.3};


        objects[i] = object;

        printf();

    }
    for(int i=0; i<MAX_OBJECTS; i++){
        printf("intialized obis for %d: %u" , i , *objects[i].code);
    }
   



    

}

int compare_obiscode(Obiscode* code1, Obiscode* code2) {


    printf("%d,%f",code1->a,code2->a);
    if (code1->a == code2->a &&
        code1->b == code2->b &&
        code1->c == code2->c &&
        code1->d == code2->d &&
        code1->e == code2->e &&
        code1->f == code2->f) {
        return 1; 
    }
    return 0; 
}*/



#include "iotm.h"
#include<stdlib.h>
#include<stdio.h>

#define MAX_OBJECTS 3

 ObisCode obis1 = {1,1,1,1,1,1};
  ObisCode obis2 = {1,1,1,1,1,2};
   ObisCode obis3 = {1,1,1,1,1,3};

CosemObject objects[] = {
    {&obis1,1.1 },
    {&obis2,2.1 },
    {&obis3,33434.435342345 },
};

void init_meter(){
    // objects = (CosemObject*) malloc(sizeof(CosemObject)*MAX_OBJECTS);
    // for (int i=0;i<MAX_OBJECTS;i++){
    //     ObisCode obis = {1,1,1,1,1,i};
    //     CosemObject object = {&obis,3.3};
    //     objects[i] = object;
    // }

    // for (int i=0;i<MAX_OBJECTS;i++){
    //     printf("intialized obis code for %d: %d\n",i,objects[i].code->f);
    // }
}

// void print_cosem_objects(){
//     for (int i=0;i<MAX_OBJECTS;i++){
//         printf("intialized obis code for %d: %d\tdata: %f\n",i,(objects[i].code->f), objects[i].data);
//     }
// }

void make_obis_code(ObisCode* code, int A, int B, int C, int D, int E, int F){
    code->a = A;
    code->b = B;
    code->c = C;
    code->d = D;
    code->e = E;
    code->f = F;
}

void make_cosem_object(CosemObject* object,ObisCode* code, float data){
    object->code = code;
    object->data = data;
}

void get_cosem_object(CosemObject* object,ObisCode* code){
    for (int i = 0; i < MAX_OBJECTS; i++){
        if ( objects[i].code->a == code->a 
            && objects[i].code->b == code->b 
            && objects[i].code->c == code->c 
            && objects[i].code->d == code->d 
            && objects[i].code->e == code->e 
            && objects[i].code->f == code->f)
        {
           object->data = objects[i].data;
           return;
        }
    }
}


int compare_obis_code(ObisCode* a, ObisCode* b){
    if (a->a == b->a && a->b == b->b && a->c == b->c && a->d == b->d && a->e == b->e && a->f == b->f){
        return 1;
    }else{
        return 0;
    }
    
}
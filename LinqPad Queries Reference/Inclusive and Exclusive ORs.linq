<Query Kind="Statements" />

//Inclusive and Exclusive OR's

bool isIceCreamLeft = false;
bool isCakeLeft = true;

//Exclusive OR (only 1 can be true)
bool isOneThingLeft = isIceCreamLeft ^ isCakeLeft; //this is only true if one item is left

//bitwise Inclusive OR
bool isThereAnythingLeft2 = isIceCreamLeft | isCakeLeft; //

bool isThereAnythingLeft3 = isIceCreamLeft || isCakeLeft; //

;
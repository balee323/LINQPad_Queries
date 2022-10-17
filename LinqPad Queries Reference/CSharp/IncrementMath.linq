<Query Kind="Statements" />


int a = 3;
int b = 4;
int e = 5;

//i++ -> tell me value then increment
//++i -> increment then tell me the value

int number1 = --a * b - ++e;  //2  first a -1 and e +1 then -> ([2*6]-6) 


int number2 = a-- * b - e++;  //7 first ([3*4]-5) -> then a-1 and e + 1


;


Console.WriteLine(number1);
Console.WriteLine(number2);
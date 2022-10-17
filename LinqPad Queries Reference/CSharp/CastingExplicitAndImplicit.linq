<Query Kind="Statements" />



//casting (implicit and explicit)


//implicit
int number = 5;
double number2 = number;


//explicit
double number3 = 5;
int number4 = (int)number3;


//conversions

public static implicit operator double(int number)
{
	double number2 = (number * 3);
	
	return number2;
	
}
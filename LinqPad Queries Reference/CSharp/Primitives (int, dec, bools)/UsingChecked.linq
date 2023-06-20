<Query Kind="Statements" />



//int32 overflow
//int32 max value = 2_147_483_647

//3 senarios
//1. Int32.Max value plus 10 will cause immediate compiler error (won't run).
//2. This will run, but cause error result as the bits are shifted and error is not noticed.
//3. Checked will produce an exception if a number becomes bigger than max value.

//1.
//int number2 = Int32.MaxValue + 10; // compiler error
Console.WriteLine($"Senario 1: Won't compile.");

//2.
int i = 2_147_483_647;

int ten = 10;	
int number = i + ten; // -2147483639 (no exception, but number is incorrect)	
Console.WriteLine($"Senario 2: {number}");

try
{
	checked
	{
		int number2 = i + ten; //Exception is thrown	
		Console.WriteLine(number2);
	}

}
catch
{
	Console.WriteLine("Senario 3: overflow detected");
}




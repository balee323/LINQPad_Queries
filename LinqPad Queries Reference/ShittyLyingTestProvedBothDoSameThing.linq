<Query Kind="Program" />

void Main()
{	
	Method1();
	Method2();		
}

void Method1(){
	
	var str = "Brian";
	
	char[] characters = str.ToCharArray();
	for (int start = 0, end = str.Length -1; start < end; start++, end--)
	{
		characters[end] = str[start];
		characters[start] = str[end];
	}
	string reversedStr = new string(characters);
	Console.WriteLine(reversedStr);
}


void Method2()
{

	var str = "Brian";

	char[] characters = str.ToCharArray();
	for (int start = 0, end = str.Length - 1; start < end; start++, end--)
	{
		characters[start] = str[end];
		characters[end] = str[start];
	}
	string reversedStr = new string(characters);
	Console.WriteLine(reversedStr);
}

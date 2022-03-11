<Query Kind="Statements" />

//Inline Switch Expression
//This is C#8 (only works on LINQPad 6+)


Console.WriteLine(GetResult("fuzz"));
Console.WriteLine(GetResult2("fuzz"));


string GetResult(string input)
{
	string result = input switch
	{
		"fizz" => "this is fizz",
		"fuzz" => "this is fuzz",
		"FizzBuzz" => "this is FizzBuzz",
		_ => throw new Exception("Oh ooh")
	};
	
	return result;
}


//This way is also a return function:
string GetResult2(string input) => input switch
{
	"fizz" => "this is fizz",
	"fuzz" => "this is fuzz",
	"FizzBuzz" => "this is FizzBuzz",
	_ => throw new Exception("Oh ooh")
};

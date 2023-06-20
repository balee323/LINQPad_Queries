<Query Kind="Program" />


public static class MyExtensions
{
	
	public static int LineCount(this string str)
	{
		return str.Split(new char [] {'\n'}, StringSplitOptions.RemoveEmptyEntries).Length;
	}	
	
}

void Main()
{

	var someText = @"this is my story.
			I have been studying a lot for this C# exam.
			I want to really really get a passing score!";

	Console.WriteLine($"Number of lines in the string: {someText.LineCount()}");
}
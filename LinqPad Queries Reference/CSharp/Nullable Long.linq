<Query Kind="Statements" />



long? num1 = null;
Console.WriteLine(num1?.ToString() ?? "it's null");

long? num2 = 15;
Console.WriteLine(num2?.ToString() ?? "it's null");
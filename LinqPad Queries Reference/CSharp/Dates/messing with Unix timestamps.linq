<Query Kind="Statements" />



var currentDocDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
currentDocDate = currentDocDate.AddSeconds(1798779600);

Console.WriteLine(currentDocDate);
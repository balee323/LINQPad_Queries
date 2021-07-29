<Query Kind="Statements" />



//Date comparison 
var date1 = DateTime.Parse("2020-01-05");
var date2 = DateTime.Parse("2020-01-03");

if (date2 < date1){
	Console.WriteLine("Date 2 is older");
}
else{
	Console.WriteLine("Date 1 is older");
}


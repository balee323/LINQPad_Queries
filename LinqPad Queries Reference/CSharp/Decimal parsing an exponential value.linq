<Query Kind="Statements" />

decimal d = Decimal.Parse("7.72E-06", System.Globalization.NumberStyles.Float);

d = Decimal.Parse("0.00005", System.Globalization.NumberStyles.Float);
Console.WriteLine(d);
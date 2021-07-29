<Query Kind="Statements" />



string input1 = "1,043.6";

string matchPattern1 = @",\d{3}";  //looking for 3 decimal characters after the ','

bool isMatched1 = Regex.IsMatch(input1, matchPattern1);

;



string input2 = "rainxxxx";  //ran = [true], rain = [true], ranxxxn = [true], rainxxx = [true]

string matchPattern2 = @"rai?n";  //matches the previous element zero or one time (meaning... i is optional)

bool isMatched2 = Regex.IsMatch(input2, matchPattern2);

;

<Query Kind="Statements" />

/*
Regex for validating Hex color codes

 hex colors start with a # then followed by 6 characters
 these values are in hexidecimal 0-9, A-F range


*/



string input = "#AB12DB";

//These only match on the first character
string matchPattern1 = @"#[ABCDEF0123456789]";  // the 2 slashes seem to not be needed
string matchPattern2 = @"#[A-F,0-9]"; //this does same as above 

//this will look at all characters for a match
string matchPattern3 = @"#[A-F,0-9]+"; //this does same as above 

//must have exactly 6 matching characters for a match
string matchPattern4 = @"#[A-F,0-9]{6}"; //this does same as above 


//must have exactly pattern exactly
input = "##AB12DB other stuff";
//let's fix this by adding in beginning anchor ^  and end anchor $
string matchPattern5 = @"^#([A-F,0-9]{6})$"; //start and end anchors added 
// let's verify the orginal string still matches
input = "#AB12DB";


// what if the string has some white space characters like space, new line, carriage returns, etc.?
input = " #AB12DB \n\r ";
//We will use the \s* to accommodate for this
string matchPattern6 = @"^\s*#([A-F,0-9]{6})\s*$"; // \s* added to beginning and end



var currentPattern = matchPattern6;
bool isMatched = Regex.IsMatch(input, currentPattern);
var match = Regex.Match(input, currentPattern);
;




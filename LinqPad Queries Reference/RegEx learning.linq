<Query Kind="Statements" />

// Regex Expressions
// @"" -- means process string as a verbatim string
// . -- means any character (wildcard)
// + -- means one or more
// \.? -- means zero or more periods
// [a-z0-9_-]{0,} -- means a-z and 0-9 and underscore and dash is acceptable (any amount of these characters) 
// [A-Z] -- match any uppercase
// [a-z] -- match any lowercase
// [0-9] -- match any integer
// [0-9]+ -- match any one or more integers
// $ -- means anchor this character at the end of a string  ex [0-9]+$ only integers can be at end.
// ^ -- means the start of a line
// | -- means 'or'
// [a-z]|[A-Z] -- lowercase or uppercase
// [a-z]{2,6}  -- means two to six letters between range of a to z.
// [char group] -- matches any single character in char group
// [^char group] -- matches any single character NOT in the group
// \w -- matches any word character
// \W -- matches any NON-Word character
// \s -- matches any white-space character
// \S -- matches any non-white-space character
// \d -- matches any decimal digit
// \D matches any character that's not a decimal digit.




//Remove one or more space characters
string input = "     Bill    Joe Mike    Bob    John     Tim";

//both match patterns do the same thing
string matchPattern1 = " +"; //one or more spaces
string matchPattern2 =  @"\s+"; //one or more spaces \s means white space

string replacePattern = "";

string cleanedNameList = Regex.Replace(input, matchPattern, replacePattern);

Console.WriteLine(cleanedNameList);



//Parse out a string and create a new string

//. means any character
//+ means one or more
//This match pattern will look at any characters that have a ':' between them.

string rawLabel = ":Bob Marley:I Shot The Sheriff:260";
matchPattern = ".+:";
replacePattern = "time - "; //replace first part and add 'time - '

string formattedLabel = Regex.Replace(rawLabel, matchPattern, replacePattern);
Console.WriteLine(formattedLabel);




rawLabel = ":Bob Marley:I Shot The Sheriff:260";
matchPattern = ".+:";
replacePattern = "time - "; //replace first part and add 'time - '

formattedLabel = Regex.Replace(rawLabel, matchPattern, replacePattern);
Console.WriteLine(formattedLabel);
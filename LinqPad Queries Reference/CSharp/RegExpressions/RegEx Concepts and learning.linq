<Query Kind="Statements" />


/*

====================================================
General pattern concepts


quantifiers:
? -> means match zero or 1 time
* -> means match zero or more times
+ -> means match 1 or more times
{some number} -> how many must be there

pattern modifiers:
i -> make case insensitive
(?i) -> how to use it.  Set a beginning

anchors:
^ -> beginning
$ -> end

Alias special character codes:
\s -> special characters like white space, new lines, etc.
(\s*) -> zero or more times special characters

character ranges:
[...]

Group with alternatives(branches):
([...]|[...])

Regex Flags [Modifiers]: (occur after the second delimeter)
https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-options
-- see the second option for using inline options
g -> Return all matches
m -> multiline (affects ^ and $)
i -> case insensitive
s -> single line
u -> unicode (not supported C#)
x -> ignore white space (C#)
====================================================

More details:
@"" -- means process string as a verbatim string
. -- means any character (wildcard)
+ -- means one or more
\.? -- means zero or more periods
[a-z0-9_-]{0,} -- means a-z and 0-9 and underscore and dash is acceptable (any amount of these characters) 
[A-Z] -- match any uppercase
[a-z] -- match any lowercase
[0-9] -- match any integer
[0-9]+ -- match any one or more integers
$ -- means anchor this character at the end of a string  ex [0-9]+$ only integers can be at end.
^ -- means the start of a line
| -- means 'or'
[a-z]|[A-Z] -- lowercase or uppercase
[a-z]{2,6}  -- means two to six letters between range of a to z.
[char group] -- matches any single character in char group
[^char group] -- matches any single character NOT in the group
\w -- matches any word character -> same as using [A-Za-z0-9]
\W -- Negated matches any NON-Word character -> same as using [^A-Za-z0-9]
\s -- matches any white-space character -> same as using [\t\f\r\n]
\S -- Negated matches any NON-white-space character -> same as using [^\t\f\r\n]
\d -- matches any decimal digit -> same as using [0-9]
\D -- Negated matches any character that's not a decimal digit. -> same as using [^0-9]


inverted matching
[^0-9] -> don't match any numbers

====================================================

Quantifiers in detail:

repetitive quantifiers:

{n} -> exactly n times
{n,} -> n or more times
{n,m} -> between n and m times
{0,m} -> between 0 and m times




====================================================

meta chracters:


====================================================



Important key points:

basic pattern -> [a-z0-9]
The pattern may need to be surrounded by delimeters -> /[a-z0-9]/ 
The pattern within the delimeter can have modifers added such as ignore case -> /[a-z0-9]/im

Different Regex engines use different pattern matching syntax. Which complicates thing a bit. There are 30+ engines with different variations.  But must are 
following the PCRE specification.

*/


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
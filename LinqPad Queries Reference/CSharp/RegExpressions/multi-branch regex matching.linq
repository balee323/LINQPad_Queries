<Query Kind="Statements" />

//Multi branch matching
string input1 = "#AB12D4";
string input2 = "#A1C";


//this will not match for input2.  The ? means the # is optional
string matchPattern1 = @"#?[A-F,0-9]{6}"; //this does same as above 

//let's put in some branching qnd this will work with both inputs (almost).  Notice the # is not captured in the match
string matchPattern2 = @"#?[A-F,0-9]{6}|[A-F,0-9]{3}"; //this does same as above 

//we need to apply the # to both branches.  We do this by group the branches together using ()
string matchPattern3 = @"#?([A-F,0-9]{6}|[A-F,0-9]{3})"; //this does same as above 

//now what if we have 2 or more # characters? We need to only match on just 1 #
input1 = "#" + input1;
input2 = "#" + input2;
// this will ensure matches only happen on proper hex color codes  Use end and beginning anchors
string matchPattern4 = @"^#?([A-F,0-9]{6}|[A-F,0-9]{3})$"; //this does same as above 
//now let's reset and make sure still matching
input1 = "#AB12D4";
input2 = "#A12";

// let's change input to be lowercase (only 1 will match
input1 = input1.ToLower();
input2 = input2.ToLower();
// now lets add the case ignore pattern modifier -- using inline option for entire pattern
// (?imnsx-imnsx)
// minus sign will disable an option
// (?i) -> the ? is always required to enable or disable an option.
string matchPattern5 = @"^#(?i)([A-F,0-9]{6}|[A-F,0-9]{3})$";


var currentPattern = matchPattern5;
var match1 = Regex.Match(input1, currentPattern);
var match2 = Regex.Match(input2, currentPattern);
;


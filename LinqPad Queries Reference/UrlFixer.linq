<Query Kind="Statements" />

string url = "http://dev-datasourceservice.babelstreet.com/datasource/search?"
+"id=7&searchTerm=president&UserToken=19F4808C-7F81-49EF-8F01-C4AB71D5E721&"
+"Latitude=37.452961&Longitude=-122.181725&Radius=1";

string[] urlBaseParts = url.Split('?');

string[] leftSideParts = urlBaseParts[1].Split('&', '=');

//encode the leftSideParts
//To build back the string after encoding the string tokens
//add = to string element on even elem number
//add & to string element on odd elem number

//build the url back:  urlBaseParts[0] + leftSide
;
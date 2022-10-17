<Query Kind="Statements">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <NuGetReference>NUnit</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>NUnit.Framework</Namespace>
</Query>

//For comparing JSON:


//1. read in the JSON as a string and deserialize to a dynamic
//2. then compare the sections of the dynamic object as such:

string path = "C:/temp/file.txt";
string expectedJson = File.ReadAllText(path);
dynamic expectedObject = JsonConvert.DeserializeObject(expectedJson);

var expectedAggs = expectedObject["aggs"];
var expectedQuery = expectedObject["query"];

var testJsonString = "";

// Act
dynamic actualObject = JsonConvert.DeserializeObject(testJsonString);
var actualAggs = actualObject["aggs"];
var actualQuery = actualObject["query"];

// Assert
Assert.AreEqual(expectedAggs, actualAggs);
Assert.AreEqual(expectedQuery, actualQuery);
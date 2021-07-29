<Query Kind="Program" />

void Main()
{
		
	var docs = new List<Document>{
		new Document{ DocumentDate = DateTime.UtcNow.ToString(), DocText = "5"},
		new Document{ DocumentDate = DateTime.Parse("07/07/2020").ToUniversalTime().ToString(), DocText = "1"},
		new Document{ DocumentDate = DateTime.Parse("07/06/2015").ToUniversalTime().ToString(), DocText = "67"},
		new Document{ DocumentDate = DateTime.Parse("01/07/2001").ToUniversalTime().ToString(), DocText = "6"}	
	};
	
	//first sort
	docs = docs.OrderBy(x => DateTime.Parse(x.DocumentDate)).ToList();	
	Console.WriteLine("TrackingMin = " + docs.First().DocumentDate);	
}


public class Documents{
 	public List<Document> Docs {get; set;} 
}


public class Document{

	public string DocumentDate {get; set;}
	public string DocText {get; set;}

}
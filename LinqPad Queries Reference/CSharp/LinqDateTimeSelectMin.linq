<Query Kind="Program" />

void Main()
{

	List<Document> docs = new List<Document>{
		new Document{DocTitle = "top 10 things", BodyText = "some text", DocumentDate = DateTime.Parse("2020/05/01"), DocumentId = 3},
		new Document{DocTitle = "top 10 things", BodyText = "some text", DocumentDate = DateTime.Parse("2010/05/01"), DocumentId = 50},
		new Document{DocTitle = "top 10 things", BodyText = "some text", DocumentDate = DateTime.Parse("2020/11/01"), DocumentId = 2}
	};	
	
	//DateTime dateMin = docs.Select(x => x.DocumentDate).Min();
	;

	//DateTime dateMin2 = docs.Select(x => DateTime.Parse(x.DocumentDateString)).Min();
	;
	
	int maxDocumentId = docs.Select(x => x.DocumentId).Max();
	;
}

public class Document
{
	
	public string DocTitle {get; set;}
	public string BodyText {get; set;}
	public int DocumentId {get; set;}
	public DateTime DocumentDate {get; set;}
	public string DocumentDateString {get; set;}
	
}
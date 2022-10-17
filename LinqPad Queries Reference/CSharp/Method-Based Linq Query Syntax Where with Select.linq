<Query Kind="Program" />

void Main()
{
	List<Document> docs = new List<Document>{
		new Document{DocTitle = "Article1", DocAuthur ="Brian", BodyText = "some text", DocumentDate = DateTime.Parse("2020/05/01")},
		new Document{DocTitle = "Article2", DocAuthur ="Brian", BodyText = "some text", DocumentDate = DateTime.Parse("2010/05/01")},
		new Document{DocTitle = "Article3", DocAuthur ="John", BodyText = "some text", DocumentDate = DateTime.Parse("2020/11/01")}
	};
	
		List<string> articleTitles = docs.Where(doc => doc.DocAuthur == "Brian")
									.Select(doc => doc.DocTitle).ToList();
											
		foreach(string articleTitle in articleTitles)
		{
			Console.WriteLine($"Article Title: {articleTitle}"); 
		}
		
		
		List<Document> selectedDocs = docs.Where(doc => doc.DocAuthur == "Brian").ToList();
		
		List<Document> selectedDocs2 = docs.Select(x => x).ToList();
		
	    List<Document> selectedDocs3 = docs.Select<Document, Document>(x => x).ToList(); //same thing as above
		
		List<string> allTitles = docs.Select(x => x.DocTitle).ToList(); 
		
		List<string> allTitles2 = docs.Select<Document, string>(x => x.DocTitle).ToList(); //same thing as above
		
}

public class Document
{
	public string DocAuthur {get; set;}
	public string DocTitle { get; set; }
	public string BodyText { get; set; }
	public DateTime DocumentDate { get; set; }
}
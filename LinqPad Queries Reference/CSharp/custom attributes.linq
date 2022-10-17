<Query Kind="Program" />

//custom attributes

void Main()
{
	var somclass = new SomeClass();
	
	
}

//Private member can only be accessed via constructor and must be positional paramerter. 
//Public member only be used as named parameter.
[Documentation("Blee", modified="12/08/2020")]
[Documentation("Blee2", modified="12/06/2020")] //Allow multiple must be set
public class SomeClass
{
	
}


[System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
public class DocumentationAttribute : System.Attribute
{
	private string author;
	public string modified;
	public int version;
	
	public DocumentationAttribute(string author)
	{
		this.author = author;
		modified = DateTime.Now.ToString();
	}
}
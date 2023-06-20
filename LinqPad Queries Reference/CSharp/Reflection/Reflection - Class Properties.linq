<Query Kind="Program" />

void Main()
{
	
	var testClass = new TestClass();
		
	Type objectModel = testClass.GetType();
	List<PropertyInfo> props = objectModel.GetProperties().ToList();

	var obj = new Object();
	foreach (PropertyInfo prop in props)
	{
		var name = prop.Name;
		var value = prop.GetValue(testClass);		
		;
	}
}



public class TestClass
{
	
	public int Number {get; set;} = 5;
	
	public string Name {get; set;} = "Sally";
	
}

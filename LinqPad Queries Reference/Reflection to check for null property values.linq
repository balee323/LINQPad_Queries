<Query Kind="Program" />

void Main()
{

	var parent = new Parent();
	
	var props = parent.GetType().GetProperties();

	foreach (PropertyInfo prop in props)
	{
		
		var value = prop.GetValue(parent);
		
		
		if (prop.GetValue(parent) == null)
		{
			throw new NullReferenceException($"The value of {prop.Name} is null in {this.GetType().Name}");
		}
	}

	;

}




class Parent {
	
	public string ParentName {get; set;}
	public int ParentAge {get; set;}
	public Child1 Child1 {get; set;}
	public Child2 Child2 {get; set;}
}


class Child1{
	
}

class Child2
{

}


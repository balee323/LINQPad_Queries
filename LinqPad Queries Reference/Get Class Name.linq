<Query Kind="Program" />

void Main()
{
	new BrianClass().GetName();
}

// You can define other methods, fields, classes and namespaces here
public class BrianClass
{
	
	
	
	public void GetName(){
		string nameOfClass = this.GetType().Name;

		Console.WriteLine($"The class name is {nameOfClass}");
	}

}
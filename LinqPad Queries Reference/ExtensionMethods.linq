<Query Kind="Program" />

void Main()
{
	
	//testing extension method
	
	int number = 5;
	
	Console.WriteLine(number + " to the power of 2 is: " + number.PowerOfTwo());
	
	Color color = new Color("blue");
	
	Console.WriteLine(color.RandomColorName());
	
}

// Define other methods and classes here

public static class ExtensionMethods
{

	public static int PowerOfTwo(this int number){
		
		return number * number;
	}

	public static string RandomColorName(this Color color)
	{
		string[] randomColorNames = new string[3] {"yellow", "green", "black"};
		
		Random rand = new Random();
		return randomColorNames[rand.Next(0,2)];		
	}


}


public class Color
{
	public string ColorName { get; set;}
	
	public Color(string colorName){
		this.ColorName = colorName;
	}
}


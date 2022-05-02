<Query Kind="Program" />

void Main()
{

	string className = "processworkerworker"; //processworkerworker
	
	Console.WriteLine(GetProcessName(className));


}

private string GetProcessName(string className)
{

	int index = className.ToLower().IndexOf("worker", StringComparison.InvariantCultureIgnoreCase);
     return index != -1 && index != 0 ? className.Remove(index) : className;
}

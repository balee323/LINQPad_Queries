<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{	
	RunFunctionThatDies();
}

void RunFunctionThatDies(){
	
	try
	{
		Task.Factory.StartNew(() => FunctionThatDies());					
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
	}
}

void FunctionThatDies(){

	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine($"I am alive [{i}]");
		Thread.Sleep(200);
	}
	
	throw new Exception("dead...");
}


<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	try
	{
		Action doStuff = () =>
		{
			DoingWork(); //not awaited
		};
		
		ExecuteThings(doStuff);
		
	}
	catch (Exception ex){
		;
		Console.WriteLine("Exception Caught");
		Console.WriteLine(ex.Message);
	}	
	
	Console.WriteLine("done");
}


private void ExecuteThings(Action someAction){

	someAction.Invoke();
	
}


private async Task DoingWork()
{
	throw new Exception("opps");
	Console.WriteLine("doing work");
}
// You can define other methods, fields, classes and namespaces here
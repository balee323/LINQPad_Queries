<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

/*
 Option 1: add async

*/

//change to async
async void Main()
{
	try
	{
		//async action delegate
		Action doStuff = async () =>
		{	
			//first solution
			await DoingWork();
		};
		
		//Invoke the delegate
		doStuff.Invoke();
		
		Thread.Sleep(1000);
		Console.WriteLine("All done, nothing to see here.  No problems :)");
	}
	catch (Exception ex){
		;
		Console.WriteLine("Exception Caught");
		Console.WriteLine(ex.Message);
	}			
}



private async Task DoingWork()
{
	//** notice exception here!
	throw new Exception("opps"); 
	Console.WriteLine("doing work");
}

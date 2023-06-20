<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

/*
 Option 2: check if task is faulted. 
 Let assume you cannot await the task.  In that case check the task for a fault.

*/

void Main()
{
	try
	{
		//action delegate
		Action doStuff = () =>
		{		
			var t = DoingWork();	
			//check if task is faulted.
			if (t.IsFaulted) {throw t.Exception;}
						
		};

		//Invoke the delegate
		doStuff.Invoke();

		Thread.Sleep(1000);
		Console.WriteLine("All done, nothing to see here.  No problems :)");
	}
	catch (Exception ex)
	{
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

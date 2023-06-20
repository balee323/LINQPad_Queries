<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>


//Unhandled exception in Task
// 4 options to solve. 1 - Wait the task, 2 - Use GetAwaiter(), 3 - check if task is faulted, 4 - make all async and await task.
// So depends on the use case 

void Main()
{
	try
	{
		Task t = new Task(ThrowException);
		t.Start();
		
		/*
		t.Wait();  -- This will cause the exception to be passed to the calling thread
		*/
		
		//option 2
		//var awaiter = t.GetAwaiter();
		//awaiter.GetResult();
	
		while (true)
		{
			Console.WriteLine("All is good, no exceptions here!");
			Task.Delay(150).Wait();
			
			// option 3
			if (t.IsFaulted) {throw t.Exception;}
		}
	}
	catch (Exception ex)
	{
		Console.WriteLine("exception occured!");
	}
}

void ThrowException()
{

	while (true)
	{
		Thread.Sleep(1000);
		throw new Exception("bad thing occured.");
	}
}


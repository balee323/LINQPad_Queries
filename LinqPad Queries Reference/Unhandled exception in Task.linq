<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>


//Unhandled exception in Task
void Main()
{
	try
	{
		Task t = new Task(ThrowException);
		t.Start();
		
		/*
		t.Wait();  -- This will cause the exception to be passed to the calling thread
		BUT this will also block
		*/	
	
		while (true)
		{
			Console.WriteLine("All is good, no exceptions here!");
			Task.Delay(150).Wait();
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


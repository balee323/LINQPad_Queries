<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{	
	CancellationTokenSource tokenSource = new CancellationTokenSource();	
	tokenSource.CancelAfter(500);
	
	try{
		Stopwatch sp = new Stopwatch();
		sp.Start();
	
		await DoThings(tokenSource.Token);

		sp.Stop();
		Console.WriteLine($"Elapsed time: {sp.ElapsedMilliseconds}");
	}
	catch(Exception ex)
	{
		Console.WriteLine("task cancellation detected in main");
	}

	Console.WriteLine("Done in main");
}

public async Task DoThings(CancellationToken token)
{
	try{

		while (!token.IsCancellationRequested)
		{
			var t = Task.Delay(2000, token);
		}
		Console.WriteLine("Done");
	}
	catch (Exception ex){
		Console.WriteLine("task cancellation detected in DoThings");
		throw;
	}
}

// You can define other methods, fields, classes and namespaces here
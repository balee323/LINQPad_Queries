<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{


	CancellationTokenSource source = new CancellationTokenSource();
	source.CancelAfter(TimeSpan.FromSeconds(30));

	try{
		var combinedToken = GetMaxTimeoutToken(source.Token);
		
		while(!combinedToken.IsCancellationRequested){
			Console.WriteLine("alive baby");
			Task.Delay(1000, combinedToken).Wait();
		}
		
		Console.WriteLine("Done");
		
	}
	catch{
		;
	}


	CancellationToken GetMaxTimeoutToken(CancellationToken requestToken)
	{
		var maxServiceCallTimeoutTokenSource = CancellationTokenSource.CreateLinkedTokenSource(requestToken);

		maxServiceCallTimeoutTokenSource.CancelAfter(TimeSpan.FromSeconds(5));

		return maxServiceCallTimeoutTokenSource.Token;
	}
}

// You can define other methods, fields, classes and namespaces here
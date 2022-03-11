<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Task Result in Sync function
void Main()
{
	Task<string> myBadassTask = new Task<string>(() =>
	{
		Thread.Sleep(2500);		
		Console.WriteLine("yo from task!");
		return ("Done with myBadass Task.");
	});

	myBadassTask.Start();

	//OR

	Task<string> t = Task<string>.Run(() =>
	{
		Thread.Sleep(500);
		Console.WriteLine("yo from Static task method!");
		return ("Done with static Task.Run() method.");
	});

	//Task.WaitAll(t, myBadassTask); //not really needed
	
	string response2 = t.Result;
	Console.WriteLine(response2);

	string response1 = myBadassTask.Result;
	Console.WriteLine(response1);

	Task.Delay(1000).Wait();
	Console.WriteLine("Yo from Main");

}


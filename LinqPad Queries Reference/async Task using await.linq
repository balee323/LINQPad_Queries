<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{	
	Task myBadassTask = new Task(() =>
	{
		Thread.Sleep(500);
		Console.WriteLine("yo from task!");
	});

	myBadassTask.Start();
	await myBadassTask;

	//OR

	Task t = Task.Run(() =>
	{
		Thread.Sleep(500);
		Console.WriteLine("yo from Static task method!");
	});
	
	await t;
	
   Console.WriteLine("Yo from Main");
	
}









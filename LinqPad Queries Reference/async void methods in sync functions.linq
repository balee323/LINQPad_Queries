<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//calling async void methods in sync functions

void Main()
{
	Task myBadassTask = new Task(() =>
	{
		Thread.Sleep(500);
		Console.WriteLine("yo from task!");
	});

	myBadassTask.Start();
	myBadassTask.Wait();

	//OR

	Task t = Task.Run(() =>
	{
		Thread.Sleep(500);
		Console.WriteLine("yo from Static task method!");
	});

	t.Wait();

	Console.WriteLine("Yo from Main");

}




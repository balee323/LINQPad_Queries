<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	
	Task myBadassTask = new Task(() =>
	{
		Thread.Sleep(500);
		Console.WriteLine("yo from task!");
	});


	myBadassTask.Start();
	myBadassTask.Wait();

	Console.WriteLine("Yo from Main");

}






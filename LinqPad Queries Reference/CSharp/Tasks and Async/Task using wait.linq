<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{	
	Task myBadassTask1 = new Task(() =>
	{
		Thread.Sleep(500);
		Console.WriteLine("yo from task1!");
	});

	Task myBadassTask2 = new Task(() =>
	{
	Thread.Sleep(500);
	Console.WriteLine("yo from task2!");
	});

	myBadassTask1.Start();
	myBadassTask2.Start();

	// this will not block
	myBadassTask1.GetAwaiter();
	Console.WriteLine("Yo from Main, I wasn't blocked!");

	// this will block
	myBadassTask2.Wait();	
	Console.WriteLine("Yo from Main, I was blocked... ");
}






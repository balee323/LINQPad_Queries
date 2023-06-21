<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Task<string> myBadassTask1 = new Task<string>(() =>
	{
		Thread.Sleep(500);
		Console.WriteLine("interal task work is complete, returing the value");
		return "This is the task value -- hi!";
	});

	Stopwatch sw = new Stopwatch();

	/*
	***************************************************************************************************
	Showing the GetAwaiter() 
    ***************************************************************************************************
	*/

/*


sw.Start();

myBadassTask1.Start();

//GetResult will only block when the value is actually used:

//here we just get the TaskAwaiter object, which won't block.  
System.Runtime.CompilerServices.TaskAwaiter<string> awaiterTask = myBadassTask1.GetAwaiter();

Console.WriteLine("Yo from Main, was I blocked?"); //we shouild see this message before the task message
Console.WriteLine($"Elapsed time: {sw.ElapsedMilliseconds}");	

//will block here now, since we are using the value resultString1;
string resultString1 = awaiterTask.GetResult();
Console.WriteLine(resultString1);
Console.WriteLine($"Elapsed time: {sw.ElapsedMilliseconds}");

sw.Stop();	
sw.Reset();

; // breakpoint

Util.ClearResults(); //clears the LinqPad console

*/

/*
***************************************************************************************************
Showing the GetAwaiter() with .GetResult() 
***************************************************************************************************
*/

///*

sw.Start();
myBadassTask1.Start();

// Here we are calling the GetWwaiter() with GetResult().  This returns a string.
// But... this will block if the string value get used, which makes sense.
string resultString2 = myBadassTask1.GetAwaiter().GetResult();

//** uncomment to show the blocking
//Console.WriteLine(resultString2); //will block if called here...

Console.WriteLine("Yo from Main, was I blocked?");
Console.WriteLine($"Elapsed time: {sw.ElapsedMilliseconds}");

//** uncomment to show this won't block
//Console.WriteLine(resultString2); //will block if called here...


; // breakpoint
sw.Stop();	
}


//*/
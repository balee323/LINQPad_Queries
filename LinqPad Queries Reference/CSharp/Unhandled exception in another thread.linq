<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>


//Unhandled exception in another thread (other than main thread)
void Main()
{
	try
	{
		Thread t = new Thread(ThrowException);

		t.Start();
		
		while(true){
			Console.WriteLine("All is good, no exceptions here!");
			Task.Delay(300).Wait();
		}

	}
	catch(Exception ex){
	
		Console.WriteLine("exception occured!");
	}
}


void ThrowException(){

	while(true){
		Thread.Sleep(1000);
		throw new Exception("bad thing occured.");
	}
}

// You can define other methods, fields, classes and namespaces here

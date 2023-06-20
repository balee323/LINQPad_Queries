<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
  <RuntimeVersion>5.0</RuntimeVersion>
</Query>



//Unhandled exception in another thread (other than main thread)
void Main()
{
	try
	{	
		Thread t = new Thread(ThrowExceptionMethod);
		t.Start();

		while (true)
		{
			Console.WriteLine("All is good, no exceptions here!");
			Task.Delay(300).Wait();
		}
		
	}
	catch(Exception ex){
	
		Console.WriteLine("exception occured!");
	}
}


void ThrowExceptionMethod(){

		while (true)
		{
			Thread.Sleep(1000);		
			throw new Exception("bad thing occured.");
		}
}


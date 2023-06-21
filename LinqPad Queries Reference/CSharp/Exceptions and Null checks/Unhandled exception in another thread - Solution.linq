<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
  <RuntimeVersion>5.0</RuntimeVersion>
</Query>


    public event EventHandler ExceptionInThreadOccurred;
	private bool _isThreadException = false;
	
	//Event Handler for exception in another thread (other than main thread)
	void Main()
	{
		try
		{
			//register event handler
			ExceptionInThreadOccurred += HandleExceptionInThreadOccurred;
			
			Thread t = new Thread(ThrowExceptionMethod);
			t.Start(ExceptionInThreadOccurred);
	
			while(true){
				Console.WriteLine("All is good, no exceptions here!");
				Task.Delay(300).Wait();
				
				//here's the check
				if(_isThreadException){
				Console.WriteLine("Exception in thread detected.");
					break;
				}
			}
	
		}
		catch(Exception ex){
		
			Console.WriteLine("exception occured!");
		}
	}
	
	
	void ThrowExceptionMethod(object handlerObject){
		
		EventHandler handler = null;
		try
		{			
			handler = (EventHandler)handlerObject;
			
			while (true)
			{
				Thread.Sleep(1000);		
				throw new Exception("bad thing occured.");
			}
		}
		catch
		{
			//evoke the event and the handler in main thread will pick up.
			handler.Invoke(this, new EventArgs());
		
		}
	}
	
	//Event handler	
	void HandleExceptionInThreadOccurred(object sender, EventArgs e)
	{
		_isThreadException = true;
	}




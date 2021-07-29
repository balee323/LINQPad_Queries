<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//playing with static objects in relation to tasks/threads with ThreadLocal.  

void Main()
{
	
	Parallel.For(0, 50, (i) => {
		var service = new Service();
		Task.Delay(1000).Wait();
		Console.WriteLine(i);
		service.RollCall();
	});
			
}

public class Service
{
	
	private static ThreadLocal<Logger> _logger;	
	private static Guid _id;

	static Service()
	{
		_logger = new ThreadLocal<Logger>(() =>
		{
			_id = Guid.NewGuid();
			return new Logger(_id.ToString());
		});
	}

	public void RollCall(){
		_logger.Value.raiseHand("I am alive");
	}
	
}


public class Logger
{
	private string _origin;
	
	public Logger(string origin){
		_origin = origin;
	}
	
	public void raiseHand(string message){

		Console.WriteLine($"From {_origin}: Message: {message}"); 
	}		
}
<Query Kind="Program" />

void Main()
{	
	try
	{
		ThrowAnAggExcetion();
	}
	
	catch (AggregateException aggEx){
		
		Console.WriteLine("*********Before flattening the Agg exception********");
		
		foreach(Exception ex in aggEx.InnerExceptions){
			Console.WriteLine(ex.Message);	
		}

		Console.WriteLine("*********After flattening the Agg exception********");
		
		foreach (Exception ex in aggEx.Flatten().InnerExceptions)
		{
			//Now you will see the full excetions!
			Console.WriteLine(ex.Message);
		}
	}
	catch (Exception ex)
	{
		//Won't see much here:
		Console.WriteLine(ex.Message);
	}
}


void ThrowAnAggExcetion(){

	//nested exceptions inside of innerExceptions
	var innerInnerExceptions = new List<Exception>{
		new Exception("Something bad happened in inside inside..."),
		new Exception("You will probably not see this..."),
		new Exception("or this..."),
		new Exception("bad..."),
		new Exception("bad...bad..bad..."),
		new Exception("just another exception"),
		new NullReferenceException("something else is null")		
	};

	var innerExceptions = new List<Exception>{
		new Exception("Something bad happened I think"),
		new OutOfMemoryException("I ran out of memory"),
		new NullReferenceException("something is null and I can't use it"),
		//nested agg exception
		new AggregateException("This is a nested Agg exception", innerInnerExceptions)
	};

	var aggEx = new AggregateException("This is an Agg Exception.  I have more nested errors!", innerExceptions)
	{

	};
	

	throw aggEx;
}
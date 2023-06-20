<Query Kind="Program" />

void Main()
{	
	List<Exception> fewAggExceptions = new List<Exception>{
		new Exception("inner exception 1"),
		new Exception("inner exception 2")
	};
	
	List<Exception> exceptions = new List<Exception>{
		new Exception("terrible"),
		new InvalidCastException("this is the wrong way to cast"),
		new EndOfStreamException("there is no more stream, only Zuhl"),
		new AggregateException("a few agg exceptions", fewAggExceptions)
	};
	
	try{
		if(exceptions.Any()){
			throw new AggregateException("many bad things", exceptions);
		}
	}
	catch(AggregateException egex){		
		Console.WriteLine("//top level exception");
		Console.WriteLine(egex.Message);	
		
		Console.WriteLine(Environment.NewLine + "//parsing each inner exception");
		foreach(Exception ex in egex.InnerExceptions){
			Console.WriteLine(ex.Message);
			//log seperate stack traces, etc.
		}

		Console.WriteLine(Environment.NewLine + "//flattening & parsing each inner exception");
		foreach (Exception ex in egex.Flatten().InnerExceptions)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
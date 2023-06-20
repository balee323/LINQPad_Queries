<Query Kind="Program" />

void Main()
{
	ISpecificWriter writer = new ConcreteWriter();
	
	SpecificClass specificClass = new SpecificClass(writer);
	
	specificClass.PerformWork("Hi!");
}


public class SpecificClass : BaseClass
{
	//this won't work since Types do not derive from an interface, they implement them. So can't convert one to another.
	public SpecificClass(ISpecificWriter specificWriter) : base(specificWriter){
		
	}		
}

public class BaseClass{
	
	
	private IBaseWriter<object> baseWriter;
	
	public BaseClass (IBaseWriter<object> writer){
		
	}
	
	public void PerformWork(string message){
		baseWriter.WriteOutString(message);
	}
}

public interface IBaseWriter<in TInput>
{	
	public void WriteOutString(TInput message);	
}

public interface ISpecificWriter : IBaseWriter<string>{
	
}

public class ConcreteWriter : ISpecificWriter
{
	public void WriteOutString(string message)
	{
		Console.WriteLine(message);
	}
}
<Query Kind="Program" />

void Main()
{
	ISpecificWriter writer = new ConcreteWriter();
	
	SpecificClass specificClass = new SpecificClass(writer);
	
	specificClass.PerformWork("Hi!");
}


public class SpecificClass : BaseClass
{
	
	public SpecificClass(ISpecificWriter specificWriter) : base(specificWriter){
		
	}		
}

public class BaseClass{
	
	private IBaseWriter<string> baseWriter;
	
	public BaseClass (IBaseWriter<string> writer){
		baseWriter = writer;
	}
	
	public void PerformWork(string message){
		baseWriter.WriteOutString(message);
	}
}

public class ConcreteWriter : ISpecificWriter
{
	public void WriteOutString(string message)
	{
		Console.WriteLine(message);
	}
}

public interface IBaseWriter<in TInput>
{	
	public void WriteOutString(TInput message);	
}

public interface ISpecificWriter : IBaseWriter<string>
{
	
}


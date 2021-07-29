<Query Kind="Program" />


//implement implicitly (both interfaces implemented in single method)
public class SampleClass : IControl, ISurface
{
	// Both ISurface.Paint and IControl.Paint call this method.
	public void Paint()
	{
		Console.WriteLine("Paint method in SampleClass");
	}
}


//implement explicitly (both interfaces implemented as 2 methods)
public class SampleClass2 : IControl, ISurface
{
	// Both ISurface.Paint and IControl.Paint call this method.
	void IControl.Paint()
	{
		Console.WriteLine("Paint method in SampleClass");
	}

	void ISurface.Paint()
	{
		Console.WriteLine("Paint method in SampleClass");
	}

}


//implement explicitly and implicitly (both interfaces implemented as 2 methods)
public class SampleClass3 : IControl, ISurface
{
	// Both ISurface.Paint and IControl.Paint call this method.
	void IControl.Paint()
	{
		Console.WriteLine("Paint method in SampleClass");
	}

	public void Paint()
	{
		Console.WriteLine("Paint method in SampleClass");
	}

}


//Interface
public interface IControl
{
	void Paint();
}
//interface
public interface ISurface
{
	void Paint();
}


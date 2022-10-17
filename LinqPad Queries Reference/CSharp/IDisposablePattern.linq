<Query Kind="Program">
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

void Main()
{
	var thing = new Unmanaged();
	thing.Dispose();
}

// Define other methods and classes here

public class Unmanaged: IDisposable
{
	private SafeHandle resource;  //from InteropServices
	
	public Unmanaged(){
		this.resource = new Microsoft.Win32.SafeHandles.SafeFileHandle(IntPtr.Zero, true);
	}
	
	public void Dispose(){
		Dispose(true);
		GC.SuppressFinalize(this);
		
	}

	protected virtual void Dispose(bool disposing)
	{
		if(disposing){
			if(resource != null)
				resource.Dispose();
		}
	}
	
	
	//finalizer (deconstructor) method	
	~Unmanaged(){
		Dispose(true); 
		//call without suppressing GC.Finalize
	}
}
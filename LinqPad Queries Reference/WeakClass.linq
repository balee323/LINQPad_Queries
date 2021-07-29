<Query Kind="Program" />

//WeakReference Class 
public class WeakClass
{
	
	private WeakReference someObject;
	
	public WeakClass(IDisposable dependency){	
		someObject = new WeakReference(dependency);		
	}
	
	private void SetIsAlive(){
		bool isAlive = someObject.IsAlive;  //read-only property
		//true if still usable, false if marked for GC		
	}
	
}
<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//All about Delegates!!

//create custom deletage.  Must have access modifier
public delegate void VoidDel();

//create a custom function delegate
public delegate bool BoolFunctionDel(string inputString);

void Main()
{
	//PlayWithCustomVoidDelegates();
	
	//PlayWithCustomBoolDelegates();
	
	//PlayWithActionDelegates();
	
	PlayWithFuncDelegates();		
}


private static void PlayWithCustomVoidDelegates()
{
	//create instance of custom delegate
	VoidDel voidDel = () => Console.WriteLine("hello World");

	//call the delegate
	voidDel();
}


private static void PlayWithCustomBoolDelegates()
{
	//Custom Function Delegate
	BoolFunctionDel boolFunctionDel = new BoolFunctionDel((word) =>
	{
		bool isMatch = false;
		if (word == "dog")
		{
			isMatch = true;
		}
		return isMatch;
	});

	//test it out
	bool isFirstMatch = boolFunctionDel("cat");
	bool isSecondMatch = boolFunctionDel("dog");

	string message = isFirstMatch ? "cat is a match" : (isSecondMatch ? "dog is a match" : "noMatches"); //nested ternary operation

	Console.WriteLine(message);
}



private static void PlayWithActionDelegates()
{
	
	//Action Delegate
	//4 ways to give an Action method
	Action a = new Action(AFunctionForTheActionDelegate); //named function
	a();

	//create instance of custom named delegate
	VoidDel voidDel = () => Console.WriteLine("hello World");
	
	Action b = new Action(voidDel); // named delegate
	b();

	Action c = new Action(delegate { Console.WriteLine("hello old style delegate"); }); //internal delegate
	c();

	Action d = new Action(() => Console.WriteLine("hello lambda delegate")); //lambda expression
	d.Invoke();
}


private async static void PlayWithFuncDelegates()
{
	//Function Delegates <string>:
	Func<string> stringFunc = new Func<string>(AFunctionForTheFuncDelegate);
	Console.WriteLine(stringFunc()); //will write out "done"

	//Function Delegate <Task<string>>:
	Func<Task<string>> funcDelegate = new Func<Task<string>>(AsyncFunctionForTheFuncDelegate);

	string result = await funcDelegate();  //await here as there's an async'
	//This does the same thing as above:
	//string result = funcDelegate().Result;
	
	Console.WriteLine(result); //will write out "done"
}


private static void AFunctionForTheActionDelegate()
{
	Console.WriteLine("hello from Named Function");
}


private static string AFunctionForTheFuncDelegate()
{
	Console.WriteLine("hello from Named Function. Instant done coming.");
	return "Done";
}

private async static Task<string> AsyncFunctionForTheFuncDelegate()
{
	Console.WriteLine("hello from Named async Function. Please wait for done.");
	await Task.Delay(3000); 
	return "Done";
}

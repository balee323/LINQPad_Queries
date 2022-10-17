<Query Kind="Statements" />

//   ----------------creating and executing an anonymous delegate

	//Func<parameter, return type>
	Func<int, string> CoolReturnDelegate = delegate (int num)
	{
		return (num * 5).ToString();
	};
	
	//executing the return (Func) delegate
	Console.WriteLine(CoolReturnDelegate(3));
	
	
	//Action<parameter, parameter>
	Action<int, string> CoolVoidDelegate = delegate (int num, string message)
	{
		Console.WriteLine("Message: " + message + (num * 5).ToString());
	};
	
	//executing the the void (Action) delegate
	CoolVoidDelegate(2, "Here is the number multiplied by 5: ");



//   ----------------creating and executing a lambda expressing

		
		
	//Func<parameter, return type>
	Func<int, string> CoolReturnLambda = (num) =>
	{
		return (num * 7).ToString();
	};
	
	//executing the return (Func) delegate
	Console.WriteLine(CoolReturnLambda(3));
	
	
	//Action<parameter, parameter>
	Action<int, string> CoolVoidLambda = (num, message) =>
	{
		Console.WriteLine("Message: " + message + (num * 7).ToString());
	};

	//executing the the void lamda (Action) delegate
	CoolVoidLambda(2, "Here is the number multiplied by 7: ");


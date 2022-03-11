<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	var result = await CallMethod("GetResult");
	Console.WriteLine(result);
}


async Task<string> CallMethod(string methodName)
{
	var token = CancellationToken.None;
	
	var client = new ApiClient();
	Type calledType = client.GetType();

	var result = await (Task<string>)calledType.InvokeMember
	   (methodName, BindingFlags.InvokeMethod, null, client, new object[] { token });
	   
	return result;
}


class ApiClient
{

	public async Task<string> GetResult(CancellationToken cancellationToken)
	{

		int i = 0;
		while (!cancellationToken.IsCancellationRequested && i < 10)
		{
			await Task.Delay(10);
			i++;
		}

		return "payload";

	}

}



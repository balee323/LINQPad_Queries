<Query Kind="Program" />

void Main()
{

							var response = new NewResponse();
							response.TotalCount = 5;
							
							var newResponse = new NewResponse();
							newResponse.TotalCount = 2;
							newResponse = null;
						  												
							if (newResponse?.Payload?.Any() == true) { response.Payload.AddRange(newResponse.Payload); }
							response.TotalCount += newResponse?.TotalCount ?? 0;
							
							Console.WriteLine(response?.Payload?.Any());
							Console.WriteLine(response.TotalCount);
}

// Define other methods and classes here


	public class NewResponse
	{
	
		public NewResponse(){}
		public List<int> Payload {get; set;}		
		public int TotalCount {get; set;}		
		
	}
<Query Kind="Program">
  <NuGetReference Version="106.15.0">RestSharp</NuGetReference>
  <Namespace>RestSharp</Namespace>
  <RuntimeVersion>3.1</RuntimeVersion>
</Query>

void Main()
{
	RestClient client = new RestClient();
	
	client.CookieContainer
	
	Uri uri = new Uri("https://wwww.babelstreet.com/jobs");
	
	Console.WriteLine(uri.Host);
	
	Console.WriteLine(uri.AbsoluteUri);
	
	Console.WriteLine(uri.ToString());
	
	RestRequest request = new RestRequest{
		Method = Method.GET
		};
		
	IRestResponse response =  client.ExecuteGetAsync(request).Result;
	
	string rawContent = response.Content;
	
}

// You can define other methods, fields, classes and namespaces here
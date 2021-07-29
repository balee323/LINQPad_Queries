<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>



void Main()
{
	
	var response = new Response();	
		 if (response?.Content != null)
	     {
	                try
	                {
	                    // Handle socialgist errors
	                    var parsed = JsonConvert.DeserializeObject<JObject>(response.Content);
					}
					catch (Exception e){
						Console.WriteLine(e.Message);
					}
			}
	
}

// Define other methods and classes here

public class Response{
	public string Content {get; set;} = " ";
}
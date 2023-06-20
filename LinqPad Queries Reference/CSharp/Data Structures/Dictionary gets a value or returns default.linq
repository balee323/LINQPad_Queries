<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
</Query>

//Dictionary gets a value or returns default (even for dictionary key that doesn't exist)
void Main()
{
	
	
	Dictionary<string, string> providerMeta = new Dictionary<string, string>();
	
	const string  EMPTY_LIST = "[\"dog\", \"cat\"]";
	
	
	string rawUrls = providerMeta.GetValueOrDefault("SiliconPresignedUrls", EMPTY_LIST);
	
	Console.WriteLine(rawUrls);
	
	var presignedUrls = JsonConvert.DeserializeObject<List<string>>(rawUrls);
	
	;
	

	
}

// You can define other methods, fields, classes and namespaces here
<Query Kind="Program">
  <NuGetReference>NEST</NuGetReference>
  <Namespace>Nest</Namespace>
  <Namespace>Elasticsearch.Net</Namespace>
</Query>

void Main()
{	
	var expectedNestJson = "{\"query\":{\"match\":{\"savedSearchId\":{\"query\":\"123456\"}}}}";
	var actualNestJson = string.Empty;
	
	var inMemoryConnection = new InMemoryConnection();	
	
	var settings = new ConnectionSettings(inMemoryConnection)
	.PrettyJson(true)
	.EnableDebugMode()
	.OnRequestCompleted(r =>
	{
		if (r.RequestBodyInBytes != null){
			actualNestJson = Encoding.UTF8.GetString(r.RequestBodyInBytes);
		}
		Console.WriteLine(actualNestJson);
	});

	ElasticClient _client = new ElasticClient(settings);
	
	DeleteStuff(_client);
	
	if(actualNestJson == expectedNestJson){
		Console.WriteLine("Passed");
	}		
}

 void DeleteStuff(ElasticClient client){

	string indexName = "someIndex";
	
	string idStr = "123456";

	DeleteByQueryResponse response = client.DeleteByQuery<SignalES>(q => q
		.Index(indexName)
		.Query(rq => rq
			.Match(m => m
				.Field(f => f.SavedSearchId)
				.Query(idStr)
			)
		)
	);
	
	Console.WriteLine();	
}

void SearchStuff(ElasticClient client)
{

	string indexName = "someIndex";

	Guid searchId = Guid.Parse("1714d5ec-f78a-4473-a44b-e3d64f816867");
	
	Func<QueryContainerDescriptor<SignalES>, QueryContainer> queryDelegate = q => q
					.Term(dataReturned => dataReturned.Field(dataValue => dataValue.SavedSearchId).Value(searchId));


	var response = client.Search<SignalES>(q => q
		.Index(indexName)
		.Query(queryRequest => queryDelegate(queryRequest))
		//.Aggregations(aggs => aggregations.Aggregate(aggs, (acc, agg) =>
		//{
		//	agg(acc);
		//	return acc;
		//}))
		
}


public void BuildAgg()
{

}

public class SignalES
{
	public long Id { get; set; }
	[Keyword]
	public string SavedSearchId { get; set; }
	[Keyword]
	public string DeviceId { get; set; }
	public DateTime Timestamp { get; set; }
	public bool IsRead { get; set; }
	[Ip(Name = "ipAddress2")]
	public string IpAddress { get; set; }
}
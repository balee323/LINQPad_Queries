<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
</Query>

void Main()
{
	BatchMeta batchMeta = new BatchMeta("Brian", Guid.Parse("3d9d08e6-e140-4aa8-8c03-789a864e7812"));
	Console.WriteLine($"BatchId {batchMeta.BatchId}, name {batchMeta.Name}");
	
	string jsonStr = JsonConvert.SerializeObject(batchMeta);	
	BatchMeta batchMeta2 = JsonConvert.DeserializeObject<BatchMeta>(jsonStr);
	Console.WriteLine($"BatchId {batchMeta2.BatchId}, name {batchMeta2.Name}");	
}

public class BatchMeta
{
	public BatchMeta(string name)
	{
		Name = name;
		BatchId = Guid.NewGuid();
	}

    [JsonConstructor]
	public BatchMeta(string name, Guid batchId)
		: this(name)
	{
		BatchId = batchId;
	}

	public string Name { get; }
	public Guid BatchId { get; private set; }
}

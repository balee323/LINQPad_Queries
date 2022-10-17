<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	//parse using an array
	
	
	//string data = "\"SEARCH_OBJECT_ID\",\"REGISTRATION_ID\",\"TIMESTAMP\",\"LATITUDE\",\"LONGITUDE\",\"FLAGS\",\"HOT\",\"IP_ADDRESS\"\n\"a7c6e1d8-60fb-4cd8-ad10-a5a7857512c9\",\"7d2c36f2-9958-3286-8ae8-ac614bf5c3d1\",1600291640000,38.93445253,-77.07443476,0,false,\"NULL\"\n\"a7c6e1d8-60fb-4cd8-ad10-a5a7857512c9\",\"7d2c36f2-9958-3286-8ae8-ac614bf5c3d1\",1600291662000,38.93428087,-77.07443476,0,false,\"NULL\"\n\"a7c6e1d8-60fb-4cd8-ad10-a5a7857512c9\",\"88eebb29-73ef-3c23-88f1-76aa2e5f4593\",1600223127000,38.9347912,-77.0748552,0,false,\"99.203.17.28\"\n\"a7c6e1d8-60fb-4cd8-ad10-a5a7857512c9\",\"a5f57d5f-4ae5-33d0-891d-2383fc693a42\",1600804596000,38.93518209,-77.07439184,128,false,\"NULL\"";
	
	string data = File.ReadAllTextAsync("C:\\temp\\BigCsv.csv").Result;
	
	//string data = File.ReadAllText("C:\\temp\\SmallCsv.csv").Trim();
	;
	
	var processedData = ProcessUsingArray(data);
	
	;
	
	
}

private IEnumerable<LocationSignal> ProcessUsingArray(string data)
{
	string[] values = data.Split('\r', '\n');

	ParallelOptions _parallelOptions = new ParallelOptions
	{
		MaxDegreeOfParallelism = 1
	};

	LocationSignal[] locationSignals = new LocationSignal[values.Length -1];
	
	Parallel.For(1, values.Length, _parallelOptions, (i) =>
	{
		if (!String.IsNullOrWhiteSpace(values[i]))
		{
			var split = values[i].Split(",");
			var locationSignal = new LocationSignal
			{

				RegistrationId = split[1],
				Timestamp = long.Parse(split[2]),
				Latitude = decimal.Parse(split[3]),
				Longitude = decimal.Parse(split[4]),
				Flags = int.Parse(split[5]),
				Hot = bool.Parse(split[6]),
				IpAddress = split[7]
			};

			locationSignals[i-1] = (locationSignal);

		}
	});

	return locationSignals;
}



public class LocationSignal
{
	/// <inheritdoc cref="ILocationSignal.RegistrationId" />
	public string RegistrationId { get; set; }

	/// <inheritdoc cref="ILocationSignal.Latitude" />
	public decimal Latitude { get; set; }

	/// <inheritdoc cref="ILocationSignal.Longitude" />
	public decimal Longitude { get; set; }

	/// <inheritdoc cref="ILocationSignal.Timestamp" />
	public long Timestamp { get; set; }

	/// <inheritdoc cref="ILocationSignal.IpAddress" />
	public string IpAddress { get; set; }

	/// <inheritdoc cref="ILocationSignal.Flags" />
	public int Flags { get; set; }

	/// <inheritdoc cref="ILocationSignal.Hot" />
	public bool Hot { get; set; }
}

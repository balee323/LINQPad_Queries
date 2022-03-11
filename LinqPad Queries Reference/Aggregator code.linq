<Query Kind="Program" />

void Main()
{
		
	List<DurationMetric> rawMetrics = new List<DurationMetric>
	{
		new DurationMetric("Node1", "database call", 100),
		new DurationMetric("Node2", "database call", 50),
		new DurationMetric("Node1", "database call", 150),
		new DurationMetric("Node1", "database call", 125),
		new DurationMetric("Node2", "api call", 500),
		new DurationMetric("Node1", "api call", 750),
		new DurationMetric("Node2", "api call", 125),		
	};
	
	var aggregatedMetrics = Aggregator.Aggregate(rawMetrics);
	;	
}


public static class Aggregator
{
	
	public static Dictionary<string, AggregateNumberMetric> Aggregate(IEnumerable<DurationMetric> rawMetrics)
	{
		Dictionary<string, AggregateNumberMetric> aggregatedMetrics = rawMetrics.Aggregate(
				new Dictionary<string, AggregateNumberMetric>(),
				(metricDictionary, rawMetric) =>
				{
					if (!metricDictionary.ContainsKey(rawMetric.Origin))
					{
						metricDictionary.Add(rawMetric.Origin, new AggregateNumberMetric());
					}

					DoNumberAggregation(metricDictionary[rawMetric.Origin], rawMetric.DurationMs);

					return metricDictionary;
				});

		return aggregatedMetrics;
		
	}

	private static void DoNumberAggregation(AggregateNumberMetric aggregatedMetric, long numberToAggregate)
	{
		aggregatedMetric.Count += 1;
		aggregatedMetric.Max = Math.Max(aggregatedMetric.Max, numberToAggregate);
		aggregatedMetric.Min = Math.Min(aggregatedMetric.Min, numberToAggregate);
		aggregatedMetric.Total += numberToAggregate;
	}
	
}

public class DurationMetric
{
	public DurationMetric(string origin, string name, long durationMs)
	{
		Origin = origin;
		Name = name;
		DurationMs = durationMs;
	}

	public string Origin { get; }
	public string Name { get; }
	public long DurationMs { get; }
}

public class AggregateNumberMetric
{
	public long Min { get; set; } = long.MaxValue;
	public long Max { get; set; }
	public long Total { get; set; }
	public long Count { get; set; }
}
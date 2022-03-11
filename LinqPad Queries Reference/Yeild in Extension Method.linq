<Query Kind="Program" />

//Yeild in a extension method 

void Main()
{
	
	List<int> numbers = new List<int>();
	
	PopulateList(numbers);
		
	
	foreach (IEnumerable<int> number in numbers.ToChunks(5))
	{
		Console.WriteLine(number);
		Console.WriteLine("Done with chunk");
	}	
}

private void PopulateList(List<int> list){
	
	for(int i = 0; i < 64; i++){
		list.Add(i);
	}
}

public static class EnumerableExtensions
{
	public static IEnumerable<List<T>> ToChunks<T>(this List<T> list, int chunkSize)
	{
		if (chunkSize <= 0)
		{
			throw new ArgumentException("Chunk size must be greater than 0");
		}

		int itemsReturned = 0;

		while (itemsReturned < list.Count)
		{
			int currentChunkSize = Math.Min(chunkSize, list.Count - itemsReturned); //Math.Min returns the smaller of 2
			
			var currentRange = list.GetRange(itemsReturned, currentChunkSize);
			
			yield return currentRange; //yeild keyword: keeps track of the iteration state (without needing an extra class to track)

			itemsReturned += currentChunkSize;
		}
	}
}

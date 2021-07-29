<Query Kind="Statements" />

string[] letters = new string[]{"c", "f", "o", "y", "g", "q", "a", "z", "o", "x", "b", "d", "e"};

for (int i = 0; i < letters.Length; i++)
{
	for (int j = i + 1; j < letters.Length; j++)
	{
	
		var item1 = letters[i];
		var item2 = letters[j];
		
		var item2IsBefore = item1.CompareTo(item2) == 1;

		Console.WriteLine("item1: " + item1);
		Console.WriteLine("item2: " + item2);

		if (item2IsBefore)
		{
			Console.WriteLine("swapping: " + item1 + " and " + item2);
			//swap positions
			letters[i] = item2;
			letters[j] = item1;		
		}
	}

	foreach (var letter in letters)
	{
		Console.WriteLine(letter);
	}

    Console.WriteLine("===============");		
}
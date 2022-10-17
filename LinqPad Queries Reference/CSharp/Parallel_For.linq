<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

ParallelOptions parallelOptions = new ParallelOptions
{
	MaxDegreeOfParallelism = 8
};

List<long> csvs = new List<long>();

for(int i = 0; i < 30_000; i++){
	csvs.Add(i);
}

Stopwatch sp = new Stopwatch();
sp.Start();

//not thread safe
Parallel.For(0, csvs.Count, (i) =>
{
	csvs[i] = csvs[i] * i + i;
	//Console.WriteLine(csvs[i]);	
});

sp.Stop();
Console.WriteLine($"Elaspsed time: [{sp.ElapsedTicks}]ticks");
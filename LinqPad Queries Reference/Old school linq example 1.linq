<Query Kind="Statements" />


int[] nums = new int[3] {0,1,2};

//linq query
var numQuery = from num in nums
where (num % 2) == 0
select num;

//action on query result
foreach (int num in numQuery){
	Console.WriteLine(num);
}
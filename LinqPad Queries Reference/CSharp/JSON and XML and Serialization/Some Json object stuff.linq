<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
</Query>

using Newtonsoft.Json;

void Main()
{
	
	var orderDetails = new List<OrderDetail>
	{
		new OrderDetail
		{
			ItemDescription = "Stadium Events",
			ItemNumber = 16575,
			Quanity = 1
		},
		new OrderDetail
		{
			ItemDescription = "Little Samson",
			ItemNumber = 58654,
			Quanity = 1
		}
	};

	

	List<bool> bools = orderDetails.Select(x => x.InStock).ToList();
	
	var toCompare = new [] {false, true};
	
	
	
	
	var stringifiedOrder = Newtonsoft.Json.JsonConvert.SerializeObject(orderDetails);
	
	;

}


public class OrderDetail
{
	public string ItemDescription { get; set; }
	public int ItemNumber { get; set; }
	public int Quanity { get; set; }
	public bool InStock { get; set; } = false;
}
// You can define other methods, fields, classes and namespaces here
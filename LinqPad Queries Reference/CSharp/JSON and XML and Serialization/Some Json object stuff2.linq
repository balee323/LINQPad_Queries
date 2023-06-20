<Query Kind="Program">
  <Namespace>Newtonsoft.Json</Namespace>
</Query>


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

	var orderDetails2 = new List<OrderDetail>
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
	
	List<List<OrderDetail>> detailss = new List<List<OrderDetail>>{orderDetails, orderDetails2}


	List<bool> bools = detailss.Select(x => x.

	var toCompare = new[] { false, true };


	bool contains = bools.Contains(toCompare);


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
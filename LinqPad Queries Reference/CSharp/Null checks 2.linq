<Query Kind="Program" />

void Main()
{	
	MockResponse response = null;
	response = new MockResponse();
	
	bool clientNull = response == null;
	bool isStatusCodeFive = response?.statusCode == 5;
	bool isContentNull = string.IsNullOrWhiteSpace(response?.Content);
	
	if (clientNull || isStatusCodeFive || isContentNull)
	{
		;		
	}
	else
	{
		;	
	}
	
}

public class MockResponse
{
	public string Content { get; set; } = " e ";
	public int statusCode { get; set; } = 4;
}
<Query Kind="Program">
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//XML Serialization/Deserialization using StringWriter
void Main()
{	
	var resultString = SerializeTheXML();	
	Console.WriteLine($"Serialized collection to XML: {Environment.NewLine} {resultString}");	
	
	List<Customer> customers = DeserializeTheXMLString(resultString);
	;
	
}

public string SerializeTheXML()
{		
	string resultString = string.Empty;
	
	XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
	
	//write to string
	using (StringWriter sw = new StringWriter())
	{
		serializer.Serialize(sw, new CustomerRepo().Customers);
		resultString = sw.ToString();
	}
		
	return resultString;
}


public List<Customer> DeserializeTheXMLString(string xmlString)
{
	List<Customer> customers = new List<Customer>();

	XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

	//write to string
	using (StringReader sr = new StringReader(xmlString))
	{
		customers = (List<Customer>)serializer.Deserialize(sr);
	}

	return customers;
}

//[XmlRoot("Customers")]
//[XmlRoot("customers")]
public class CustomerRepo
{
	//[XmlArray("Customers")] //nope
    //[XmlArrayItem("Customers")] //nope
	//[XmlArrayAttribute("Items")] //nope
	[XmlElement("blah")]
	public List<Customer> Customers {get; set;} = 
		new List<Customer>{
			new Customer{ CustomerID = 1, FirstName ="Brian", LastName = "Lee", CompanyName = "BabelStreet"},
			new Customer{ CustomerID = 2, FirstName ="Yeji", LastName = "Choi", CompanyName = "IP"},
			new Customer{ CustomerID = 3, FirstName ="Connor", LastName = "Lee", CompanyName = "CJL.Inc"},
		};	
}

[XmlRoot("Customer")]
public class Customer
{	
	[XmlAttribute("CustId")]
	public int CustomerID {get; set;}
	public string FirstName {get; set;}
	public string LastName {get; set;}
	public string CompanyName {get; set;}	
}
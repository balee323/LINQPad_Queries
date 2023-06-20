<Query Kind="Program" />

//Parsing XML String and adding nodes Using XDocument (much much simpler code)

void Main()
{
	new XMLBuilder().BuildXML();
}

public class XMLBuilder
{
	public void BuildXML()
	{

		XDocument xmlDoc = XDocument.Parse(XmlStringSampleRepo.sampleXMLDoc);
				
		Console.WriteLine($"XMLDoc = {Environment.NewLine} {xmlDoc.ToString()}");
		
		//now let's add some nodes.		
		XElement customer1 =
			new XElement("Customer",				
				new XElement("FirstName", "Yeji"),
				new XElement("LastName", "Choi"),
				new XAttribute("customerID", "2")); //attributes are added to the end when building a node


		XElement customer2 =
		new XElement("Customer",
			new XElement("FirstName", "Connor"),
			new XElement("LastName", "Lee"),
			new XAttribute("customerID", "3")); //attributes are added to the end when building a node


		//add them to the root node
		xmlDoc.Root.Add(customer1);
		xmlDoc.Root.Add(customer2);
		
		Console.WriteLine($"XMLDoc = {Environment.NewLine} {xmlDoc.ToString()}");
	}
	
}


public class XmlStringSampleRepo
{
	public static string sampleXMLDoc =
		@"<?xml version=""1.0"" encoding=""UTF-8""?>
			<Customers>
				<!-- Just a comment since it's required -->
				<Customer customerID=""1"">									
					<FirstName>Brian</FirstName>
					<LastName>Lee</LastName>
				</Customer>
			</Customers>";

	public static string sampleXMLSchema =
		@"<xs:schema xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
			<xs:element name=""Customers"">
				<xs:complexType>
					<xs:sequence>
						<xs:element name=""Customer"" maxOccurs=""unbounded"" minOccurs=""0"">
							<xs:annotation>
								<xs:documentation>This is documentation</xs:documentation>
							</xs:annotation>
							<xs:complexType>
								<xs:sequence>
									<xs:element type=""xs:string"" name=""Title""/>
									<xs:element type=""xs:string"" name=""FirstName""/>
									<xs:element type=""xs:string"" name=""LastName""/>
								</xs:sequence>
								<xs:attribute type=""xs:byte"" name=""customerID"" use=""required"" />
							</xs:complexType>
						</xs:element>
					</xs:sequence>
				</xs:complexType>
			</xs:element>
		</xs:schema>";

}
<Query Kind="Program" />

//Update XML using XDocument (much much simpler code)

void Main()
{
	new XMLBuilder().BuildXML();
}

public class XMLBuilder
{
	public void BuildXML()
	{

		XDocument xmlDoc = XDocument.Parse(XmlStringSampleRepo.sampleXMLDoc);
			
		//now let's update a node:
		
		//let's find Connor Lee
		XElement customer = xmlDoc.Descendants("Customer")
			.Where(cus => cus.Attribute("customerID").Value == "3")
			.Select(cus => cus).SingleOrDefault();
		
		//should show just Conner Lee
		Console.WriteLine($"Selected Node = {Environment.NewLine} {customer.ToString()} {Environment.NewLine}");
		
		//let's change a couple things
		customer.Element("FirstName").Value = "Jihoon";
		customer.Attribute("customerID").Value = "5";
		
		Console.WriteLine($"XMLDoc = {Environment.NewLine} {xmlDoc.ToString()} {Environment.NewLine}");
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
				<Customer customerID=""2"">									
					<FirstName>Yeji</FirstName>
					<LastName>Choi</LastName>
				</Customer>
				<Customer customerID=""3"">									
					<FirstName>Connor</FirstName>
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
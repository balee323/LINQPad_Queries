<Query Kind="Program">
  <Namespace>System.Xml.Schema</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	new XMLBuilder().BuildXML();	
}

public class XMLBuilder
{	
	public void BuildXML()
	{
			
		//setting the schema for enforcement
		XmlSchemaSet sc = new XmlSchemaSet();
		sc.Add(BuildXMLSchema());
		
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.Schemas = sc; //set XML Schema
		
		TextReader textReader = new StringReader(XmlStringSampleRepo.sampleXMLDoc);			
		xmlDoc.Load(textReader); //load XML from stream

		//schema validates now as elements and attributes are present and match
		xmlDoc.Validate(ValidationHandler);

		//or Serialize to String using TextWriter (a bit abstracted)
		using (StringWriter textWriter = new StringWriter())
		{
			XmlSerializer ser = new XmlSerializer(typeof(XmlDocument));
			ser.Serialize(textWriter, xmlDoc);
			string str = textWriter.ToString();
			Console.WriteLine($"XMLDoc = {Environment.NewLine} {str}");			
		}		
	}


    private XmlSchema BuildXMLSchema()
	{
		//setup XMLSchema
		TextReader textReader = new StringReader(XmlStringSampleRepo.sampleXMLSchema);
		XmlSchema xmlSchema = XmlSchema.Read(textReader, ValidationHandler); //Set Schema Verifier function

		//Verify the XML Schema looks right
		XmlSerializer ser = new XmlSerializer(typeof(XmlSchema));

		//long-way to serialize to MemoryStream (lower-level)
		MemoryStream ms = new MemoryStream();
		TextWriter writer = new StreamWriter(ms);
		ser.Serialize(writer, xmlSchema); //serialize to MemoryStream
		writer.Flush(); //write to MemoryStream 	
		ms.Position = 0;
		using (StreamReader reader = new StreamReader(ms))
		{
			var rawSchema = reader.ReadToEnd();
			//Console.WriteLine($"Schema = {rawSchema}");
		}

		//or Serialize to String using TextWriter (a bit abstracted)
		using (StringWriter textWriter = new StringWriter())
		{
			ser = new XmlSerializer(typeof(XmlSchema));
			ser.Serialize(textWriter, xmlSchema);
			string str = textWriter.ToString();

			//Console.WriteLine($"Schema = {str}");
			
			return xmlSchema;
		}
	}

	private void ValidationHandler(object sender, ValidationEventArgs args)
	{
		if (args.Severity == XmlSeverityType.Warning) //only 2 severity types: Warning & Error
			Console.Write("WARNING: ");
		else if (args.Severity == XmlSeverityType.Error)
		{
			Console.Write("ERROR: ");
			//Could also throw an exception
			throw new XmlException(args.Message);
		}
			
		Console.WriteLine(args.Message);		
	}

}


public class XmlStringSampleRepo
{	
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
		
		public static string sampleXMLDoc =
			@"<?xml version=""1.0"" encoding=""UTF-8""?>
			<Customers>
				<!-- Just a comment since it's required -->
				<Customer customerID=""1"">					
				
					<FirstName>Brian</FirstName>
					<LastName>Lee</LastName>
				</Customer>
			</Customers>";
}
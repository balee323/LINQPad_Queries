<Query Kind="Program">
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

public class Classroom
{
	public string RoomNumber { get; set; }
}

void Main()
{
	
	Classroom room = new Classroom();
	room.RoomNumber ="100A";
	//need to create this output:  <classroom number = "100A"/>	


	XmlAttributes roomNumberAttributes = new XmlAttributes();
	roomNumberAttributes.XmlAttribute = new XmlAttributeAttribute("Number");
	
	XmlAttributeOverrides overrides = new XmlAttributeOverrides();
	overrides.Add(typeof(Classroom), "RoomNumber", roomNumberAttributes);	
	XmlSerializer serializer = new XmlSerializer(typeof(Classroom), overrides);
	
	
	//XmlSerializer serializer = new XmlSerializer(typeof(Classroom));
	
	MemoryStream stream = new MemoryStream();
	serializer.Serialize(stream, room);
	
	stream.Position = 0;
	
	string xml = string.Empty;
	using (StreamReader reader = new StreamReader(stream))
	{
		xml = reader.ReadToEnd();
		;
	}
		
			;
}
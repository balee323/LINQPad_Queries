<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
</Query>

void Main()
{

	
	object obj = new Car{Name = "brian's car", Milage = 25_000};
		
	string json = JsonConvert.SerializeObject(obj);
		
	Console.WriteLine(json);
	
	
	GenericProcessor(obj, json);
	
	
}


private void GenericProcessor(object messageType, string jsonString){
	
	Type objectType = messageType.GetType();	

	Car car = new Car();
	 
	Type t = car.GetType();
	;


	//becomes a JObject
	Car specificObject = JsonConvert.DeserializeObject<Car>(jsonString);
	
	//becomes a JObject
	var genericObject = JsonConvert.DeserializeObject(jsonString);
	
	;
}


public class Car
{
	public string Name {get; set;}
	public int Milage {get; set;}
}








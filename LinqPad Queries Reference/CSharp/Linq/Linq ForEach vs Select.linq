<Query Kind="Program" />

void Main()
{		
	List<Car> cars = new List<Car>{
		new Car{CarMake = "Ford", CarModel = "Ranger"},
		new Car{CarMake = "Ford", CarModel = "Maveric"},
		new Car{CarMake = "Toyota", CarModel = "Tacoma"},
		new Car{CarMake = "Dodge", CarModel = "Ram"},
	};
	
	//this won't change the value!!
	cars.Select(x => x.CarId = Guid.NewGuid().ToString());
	;
	//this will change the value!!
	cars.ForEach(x => x.CarId = Guid.NewGuid().ToString());
	;	
	
	List<string> batchId = new List<string>();

	cars.ForEach(x =>
	{
		x.CarId = Guid.NewGuid().ToString();
		batchId.Add(x.CarId);
	});
	
	;

}


class Car{
	
	public string CarMake {get; set;}
	public string CarModel {get; set;}
	public string CarId {get; set;} = new Guid().ToString();	
}

// You can define other methods, fields, classes and namespaces here
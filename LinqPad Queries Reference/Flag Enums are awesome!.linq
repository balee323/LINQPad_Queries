<Query Kind="Program" />

//BITWISE operations and Flag enums
[Flags]
enum Food : byte
{
	None = 0,
	Fries = 1,
	OnionRings = 2,
	Salad = 4,
	Bread = 8,
	Burger = 16,
	Shrimp = 32,
	Cake = 64,
	IceCream = 128
}

void Main()
{
	Food food = Food.Cake | Food.Salad | Food.OnionRings; //this sets the enum
	
	/*	set the enum flags:
		0100 0000 Cake (64)
		0000 0100 Salad (4)
	OR	0000 0010 OnionRings (2)
		---------------------
		0100 0110 foods   (70)
				
		check for cake:
		0100 0110 foods  (70)
	AND	0100 0000 cake   (64)
		--------------------
		0100 0000 cake   (64) -> cake is present!!				
	*/
	
	if ((food & Food.Bread) == Food.Bread || (food & Food.OnionRings) == Food.OnionRings)
	{
		Console.WriteLine($"Order might include bread or onion rings. Enum int value is :{(int)food}");	
	}
	else
	{
		Console.WriteLine($"Order was for something else {food}. Enum int value is :{(int)food}");
	}
	
}





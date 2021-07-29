<Query Kind="Statements" />

//working with Bits

//.Net uses Two's Complement for sign flag
sbyte flag = -128; //max value is 127 neg128-127 (signed integer has sign bit)

byte flag2 = 255; //max value for unsigned is 255 0-255 (no negatives)

//byte flagByte = Convert.ToByte(flag);

//int bitValue = flagByte << 1;

//displays in boolean
//for(int i = 7; i >= 0; i--){
//	Console.Write(1 == ((flagByte >> i) & 1));
//}

Console.WriteLine(Environment.NewLine);

//displays in int
//for (int j = 7; j >= 0; j--)
//{
//Console.Write(flagByte >> j & 1);	
//}


for (int k = 7; k >= 0; k--)
{
	Console.Write(flag >> k & 1);
}

Console.WriteLine(Environment.NewLine);
	
for (int k = 7; k >= 0; k--)
{
	Console.Write(flag2 >> k & 1);
}

;








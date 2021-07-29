<Query Kind="Statements" />

//Narrowing integer values:

//narrowing a positive
short posNum = 575;
byte narrowedPosNumber = (byte)posNum;
Console.WriteLine(narrowedPosNumber); //63

//the bits are just cut.
//0000 0010 0011 1111  ->  0011 1111 (63)


//narrowing a negative
short negNum = -575;
byte narrowedNegNumber = (byte)negNum;
Console.WriteLine(narrowedNegNumber); // 193

//the bits are just cut.
//1111 1101 1100 0001->  1100 0001  (193)


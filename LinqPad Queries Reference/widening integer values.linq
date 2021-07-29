<Query Kind="Statements" />

//widening integer values:

//widening a positive

sbyte posNum = 3;
short widenedPosNumber = (short)posNum;  
Console.WriteLine(widenedPosNumber); //3

//when widening negative numbers, all the extra left bits are set to 1.
//000 0011 (3) convert to 16 bit -> 0000 0000 0000 0011


//widening a negative

sbyte negNum = -3;
short widenedNegNumber = (short)negNum;  //with ushort this becomes 65533!
Console.WriteLine(widenedNegNumber); //-3

//when widening negative numbers, all the extra left bits are set to 1.
//1111 1101 (-3) convert to 16 bit -> 1111 1111 1111 1101


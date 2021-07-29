<Query Kind="Statements" />

//trying to cause an overflow...
sbyte num1 = -128;
sbyte num2 = -1;

sbyte answer = (sbyte)(num1 - num2);
Console.WriteLine(answer);

sbyte answer2 = (sbyte)(num1 * num2);  //this should have caused an overflow lol
Console.WriteLine(answer2); 


//sbyte answer3 = (sbyte)(
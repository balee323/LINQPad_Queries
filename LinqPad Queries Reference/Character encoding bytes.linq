<Query Kind="Statements" />

//Character encoding bytes

string name = "Brian";

//ASCII is 1 byte per char
//Unicode (alias for UTF16) is 2 bytes per char
//UTF7 is 1 byte per char
//UTF8 is 1 byte per char
//UTF32 is 4 bytes per char

List<byte> namebytesInASCII = Encoding.ASCII.GetBytes(name).ToList(); //1 byte per char
List<byte> namebytesInUnicode = Encoding.Unicode.GetBytes(name).ToList(); //2 byte per char

foreach (byte b in namebytesInASCII){
	Console.Write(Convert.ToString(b, 2) + " ");
}

Console.WriteLine();

foreach (byte b in namebytesInUnicode)
{
	//Console.Write(b + " ");
	Console.Write(Convert.ToString(b, 2) + " ");
}
 
Console.WriteLine();
 
//And just for fun, let's look at booleans:

bool isItHotOutside = true;

byte boolByte = Convert.ToByte(isItHotOutside);

Console.WriteLine(Convert.ToString(boolByte, 2));
 
;
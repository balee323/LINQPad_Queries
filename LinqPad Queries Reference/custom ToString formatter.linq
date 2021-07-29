<Query Kind="Program" />

void Main()
{
	
		MusicTrack song = new MusicTrack(artist: "Bob Marley", title: "I shot the Sheriff");
		
		Console.WriteLine("Track: {0:F}", song);
	    Console.WriteLine("Artist: {0:A}", song);
	
}

// Define other methods and classes here


class MusicTrack : IFormattable
{

	public MusicTrack(string artist, string title)
	{
		Artist = artist;
		Title = title;
	}

	string Artist { get; set; }
	string Title { get; set; }

	public string ToString(string format, IFormatProvider formatProvider) //formatProvider is auto-defaulted to use current culture. 
	{

		if (string.IsNullOrWhiteSpace(format))
		{
			format = "G";
		}

		switch (format)
		{
			case "A": return Artist;
			case "T": return Title;
			case "G": //default format
			case "F": return Artist + " " + Title;
			default:
				throw new FormatException("Format specifier was invalid");

		}
	}

	public override string ToString()
	{
		return Artist + " " + Title;
	}	

}
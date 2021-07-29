<Query Kind="Program" />

void Main()
{
	
	List<MusicTrack> allTracks = new List<MusicTrack>
	{
		new MusicTrack
		{
			Title ="Cool tunes",
			Artist = new Artist {Name="Brian", Genre="Rap"}
		},

		new MusicTrack
		{
			Title ="Frozen tunes",
			Artist = new Artist {Name="Brian", Genre="Rap"}
		},
			new MusicTrack
		{
			Title ="Show tunes",
			Artist = new Artist {Name="John", Genre="Classical"}
		},
			new MusicTrack
		{
			Title ="Sad tunes",
			Artist = new Artist {Name="Mike", Genre="Country"}
		}
	};

	//Note:  none of the query results will have any values until an execution is forced.
	//Right now the value of selectedTracks for example, will be null.
	
	//return a IEnumerable of type MusicTrack
	var selectedTracks = from track in allTracks
						where track.Artist.Name == "Brian"
						select track;

	//force execution of results
	var result = selectedTracks.ToList(); //or ToArray() or ToDictionary()

	//return a IEnumerable of type ArtistDetails
	var selectedDetails = from track in allTracks
						 where track.Artist.Name == "Brian"
						 select new ArtistDetails{
						 	Title = track.Title,
							Name = track.Artist.Name,
							Genre = track.Artist.Genre
						 };


	//return a IEnumerable of type anonymous type object
	var anonmousDetails = from track in allTracks
						  where track.Artist.Name == "Brian"
						  select new
						  {
							  Title = track.Title,
							  Name = track.Artist.Name,
							  Genre = track.Artist.Genre
						  };

	
	//And the same for method-based Linq syntax.
	var query = allTracks.Where(x => x.Artist.Name == "Brian");
	;
	
	var results2 = query.ToList();
	;


}



class MusicTrack
{
	
	public string Title {get; set;}
	public Artist Artist {get; set;}
	
}

class Artist
{
	public string Name {get; set;}
	public string Genre {get; set;}
}


class ArtistDetails
{
	public string Title {get; set;}
	public string Name {get; set;}
	public string Genre {get; set;}
}
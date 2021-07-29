<Query Kind="Program" />

void Main()
{	
	var post = new Post();	
    int postLikes = post?.Likes?.Summary?.total_count ?? 0;
	 
	Console.WriteLine(postLikes);
}
	 	 
	public class Post
	{ 
	 	public Post(){}
		public Like Likes {get; set;}		 
	}
	 
	public class Like
	{
	 	public Summary Summary {get; set;} = null;				
	}
	 
	 
    public class Summary
	{	 
	 	public int total_count {get; set;}
	}
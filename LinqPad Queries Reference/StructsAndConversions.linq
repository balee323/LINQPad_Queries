<Query Kind="Program" />


//Structs and conversions
void Main()
{		
	
	Point2d p0 = new Point2d(3d, 5d, "Point1");	
	Point2d p1 = new Point2d(3d, 5d);	
	
	Point3d p2 = (Point3d) new Point2d(3d, 5d);	
	Point2d p3 = (Point2d) new Point3d(1d, 2d, 3d);	
	;
}


public struct Point2d
{
	public double X {get; set;}
	public double Y {get; set;} 	
	public string PointName {get; set;}
	
	public Point2d(double x, double y, string pointName) :this()
	{
		X=x;
		Y=y;
		PointName = pointName;
	}
		
	public Point2d(double x, double y) :this(y)
	{
		X=x;
	}
	
	public Point2d(double y)
	{
		X=5;
		Y=y;
		PointName = "Unknown";
	}

}

public struct Point3d
{
	//conversion code (doesn't matter which struct this is in it seems)
	public static implicit operator Point3d(Point2d value)
	{
		return new Point3d(value.X, value.Y, -6d);
	}

	//conversion code (doesn't matter which struct this is in it seems)
	public static explicit operator Point2d(Point3d value)
	{
		return new Point2d(value.X, value.Y);
	}

	public double X {get; set;}
	public double Y {get; set;}
	public double Z {get; set;}
	
	public Point3d(double x, double y, double z): this()
	{		
		X=x;
		Y=y;
		Z=z;
	}	
}
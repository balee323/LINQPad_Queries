<Query Kind="Program" />

void Main()
{
	
	string strDate1 = "2022-01-01 12:34:05.759 Z";
	string strDate2 = "2022-01-01 12:59:05.759 Z";
	string strDate3 = "2022-01-01 12:01:05.759 Z";

	System.DateTime ? testDate1 = DateUtil.ParseStringIntoDateTime(strDate1);
	System.DateTime ? testDate2 = DateUtil.ParseStringIntoDateTime(strDate2);
	System.DateTime ? testDate3 = DateUtil.ParseStringIntoDateTime(strDate3);
	
	Console.WriteLine(DateUtil.RemoveMinutes(testDate1.Value));
	Console.WriteLine(DateUtil.RemoveMinutes(testDate2.Value));
	Console.WriteLine(DateUtil.RemoveMinutes(testDate3.Value));
		
	;
}



public class DateUtil
{

	public static DateTime? ParseStringIntoDateTime(string dateString)
	{
		if (!string.IsNullOrWhiteSpace(dateString))yea
		{
			return DateTime.Parse(dateString);
		}

		return null;
	}

	public static DateTime RemoveMilliseconds(DateTime dateTime)
	{
		return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute,
			dateTime.Second, dateTime.Kind);
	}

	public static DateTime RemoveMinutes(DateTime dateTime)
	{
		return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0, dateTime.Kind);
	}
}
<Query Kind="Program" />

void Main()
{
	
	
	string strDate1 = "2013-01-25T00:11:02+0000";
	
	string strDate2 = "2016-05-25T00:11:02+0000";
	
	//strDate = null;
	
	var date = GetFacebookItemDate(!String.IsNullOrWhiteSpace(strDate1) ? strDate1 : strDate2);
	
	Console.WriteLine("date =  " + date);
	
	
}



			
        private string GetFacebookItemDate(string stringDateTime)
        {
            string tempTime = stringDateTime?.Replace("T", " ").Trim();
            tempTime = tempTime?.Length > 0 ? tempTime?.Substring(0, tempTime.LastIndexOf('+')) : string.Empty;

            if (DateTime.TryParse(tempTime, out DateTime convertedCreationTime))
            {
                //if the conversion works then set the time to the table row
                return convertedCreationTime.AddSeconds(-10).ToString();
            }
            return DateTime.UtcNow.ToString();
        }
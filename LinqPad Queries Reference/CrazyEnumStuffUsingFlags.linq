<Query Kind="Program" />



[Flags]
enum Days : short
{
	Sunday = 1,
	Monday = 2,
	Tuesday = 4,
	Wednesday = 8,
	Thursday = 16,
	Friday = 32,
	Saturday = 64,
	weekend = Sunday | Saturday
}


void Main()
{
	//bitwise operators...
	//| 
	//&

	  
	Days meetingDays = Days.Monday | Days.Wednesday;  //10


	var friday = Days.Friday; //32
	var thing1a = meetingDays & Days.Friday;  //0
	var thing1b = Days.Friday & meetingDays;  //0
	var thing2 = meetingDays | Days.Friday;   //42	
	
	bool isFridayMeetingDay = (meetingDays & Days.Friday) == Days.Friday;

	var wednesday = Days.Wednesday; //8
	var thing3a = Days.Monday & Days.Wednesday; //0   (2,8)
	var thing3b = Days.Monday | Days.Wednesday; //10  (2,8)	
	var thing4 = meetingDays & Days.Wednesday; //8
	
	var thing5 = 1 & 1; //1
	var thing6 = 1 | 1; //1
	var thing7a = 2 | 4; //6
	var thing7b = 2 & 4; //0
	var thing7c = 1 & 3;//1
		
	bool isWednesdatMeetingDay = (meetingDays & Days.Wednesday) == Days.Wednesday;

	;
}



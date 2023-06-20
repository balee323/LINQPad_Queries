<Query Kind="Program" />

void Main()
{
	//must run as admin!
	
	string logName = "LinqPadTestLog";	
	string sourceName = "LinqPadSource";
	
	//create logsource if doesn't exist
	if(!EventLog.SourceExists(sourceName))
	{
		//create the source for the app
		EventSourceCreationData mySourceData = new EventSourceCreationData(sourceName, logName);
	}
	
	//let's log something
	
	//setup the log
	EventLog eventLog = new EventLog(logName);
	eventLog.Source= sourceName;


	//actually log it (informational)
	eventLog.WriteEntry("Test entry, can you see this Info?", EventLogEntryType.Information);

	//actually log it (warning)
	eventLog.WriteEntry("Test entry, can you see this warning?", EventLogEntryType.Warning);
	
	//actually log it (error)
	eventLog.WriteEntry("Test entry, can you see this error?", EventLogEntryType.Error);


	//Windows button, search for event viewer
	
}
<Query Kind="Program" />

void Main()
{	
	var signals = new List<Signal>{
		new Signal{SearchId = "bleeSearch", SignalId = "1111"},
		new Signal{SearchId = "bleeSearch", SignalId = "1234"},
		new Signal{SearchId = "lauroSearch", SignalId = "1122"},
		new Signal{SearchId = "bleeSearch", SignalId = "1356"},
		new Signal{SearchId = "TejaSearch", SignalId = "1575"},
		new Signal{SearchId = "TejaSearch", SignalId = "2233"},
		new Signal{SearchId = "bleeSearch", SignalId = "3322"},
		new Signal{SearchId = "BradSearch", SignalId = "4585"},
		new Signal{SearchId = "bleeSearch", SignalId = "2387"}
	};
	
	
    //Dictionary<string, List<Signal>> SignalsBySearchId = new Dictionary<string, List<Signal>>()

	 Dictionary<string, List<Signal>> SignalsBySearchIds = signals.GroupBy(sig => sig.SearchId).ToDictionary(dic => dic.Key, dic => dic.ToList());
	
	;
	;
}





class Signal{
	
	public string SignalId {get; set;}
	public string SearchId {get; set;}
	
}
// You can define other methods, fields, classes and namespaces here
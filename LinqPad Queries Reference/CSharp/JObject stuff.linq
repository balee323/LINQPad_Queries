<Query Kind="Statements" />

   
   
   var topic = "omelas is the best";
   
   var IsOmelas = topic.ToLower().Contains("omelas");


   var Origin =  (JObject)JsonConvert.DeserializeObject(request)["BatchMeta"]["origin"]

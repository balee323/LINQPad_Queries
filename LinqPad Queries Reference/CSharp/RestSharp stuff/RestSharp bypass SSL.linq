<Query Kind="Statements" />

//add this to get Restsharp to bypass SSL stuff

var options = new RestClientOptions("some base url")
{
	RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
};


var restClient = new RestClient(options);

var restRequest = new RestRequest(resource, Method.Post);
restRequest.AddParameter("text/json", data, ParameterType.RequestBody);

// Call the endpoint...
var restResponse = await restClient.ExecuteAsync<T>(restRequest);

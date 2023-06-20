<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	//var fileUrl = "https://effigis.com/wp-content/uploads/2015/02/Airbus_Pleiades_50cm_8bit_RGB_Yogyakarta.jpg";  //50 MB
	var fileUrl = "http://212.183.159.230/512MB.zip"; //200MB
													  //

	//https://en.wikipedia.org/wiki/Video_file_format
	for (int i = 0; i < 500; i++)
	{
		await DownloadToFile(fileUrl, $"C:\\temp\\images\\bigFile{i}.jpg");
		//await DownloadDirectlyToFile(fileUrl, $"C:\\temp\\images\\bigFile{i}.jpg");
	}

}

//download large file
private async Task DownloadDirectlyToFile(string fileUrl, string filePath)
{
	Console.WriteLine(filePath);
		
	var webClient = new System.Net.WebClient();
	var url = fileUrl;
	await webClient.DownloadFileTaskAsync(new Uri(url), filePath);
}



//download large file
private async Task DownloadToFile(string url, string filePath)
{
	Console.WriteLine(filePath);
	
	var webClient = new System.Net.WebClient();
	
	var uri = new Uri(url);
	var data = await webClient.DownloadDataTaskAsync(uri);
		
	await File.WriteAllBytesAsync(filePath, data);
	
	await File.WriteAllBytesAsync(
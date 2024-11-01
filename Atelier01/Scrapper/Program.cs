// WriteLine("Hello, World!");

HttpClient client = new HttpClient();

try
{   
    if (args.Length == 0){
    string entry = ReadLine();
    args =  new string[]{entry};
    } 
    
    foreach (var url in args)
    {
        using HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        long responseBody = response.Content.Headers.ContentLength?? -1;
        Console.WriteLine(responseBody);
    }

}
catch (HttpRequestException e)
{
    Console.WriteLine("\nException Caught!");
    Console.WriteLine("Message :{0} ", e.Message);
}
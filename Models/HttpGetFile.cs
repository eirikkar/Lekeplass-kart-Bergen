class HttpGetFile
{
    static readonly HttpClient client = new HttpClient();

    public async Task<Stream> Run()
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync(
                "https://raw.githubusercontent.com/datahotellet/dataset-archive/refs/heads/main/datasets/bergen/lekeplasser/dataset.csv"
            );
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStreamAsync();
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
            throw;
        }
    }
}

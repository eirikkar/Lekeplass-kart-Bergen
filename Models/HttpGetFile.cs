namespace Lekeplass_kart_Bergen.Models;

class HttpGetFile
{
    static readonly HttpClient client = new HttpClient();

    public static async Task GetCsv()
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync(
                "https://raw.githubusercontent.com/datahotellet/dataset-archive/refs/heads/main/datasets/bergen/lekeplasser/dataset.csv"
            );
            response.EnsureSuccessStatusCode();
            var toFile = await response.Content.ReadAsStringAsync();
            File.WriteAllText("data/lekeplasser.csv", toFile);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
            throw;
        }
    }
}

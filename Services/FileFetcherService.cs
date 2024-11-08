namespace Lekeplass_kart_Bergen.Services;

public class FileFetcherService : IFileFetcher
{
    private readonly HttpClient _httpClient;

    public FileFetcherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Stream> GetCsvAsync()
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(
                "https://raw.githubusercontent.com/datahotellet/dataset-archive/refs/heads/main/datasets/bergen/lekeplasser/dataset.csv"
            );
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStreamAsync();
        }
        catch (HttpRequestException e)
        {
            Console.Error.WriteLine($"Request error: {e.Message}");
            throw;
        }
    }
}

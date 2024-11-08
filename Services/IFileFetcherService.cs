namespace Lekeplass_kart_Bergen.Services;

public interface IFileFetcherService
{
    /// <summary>
    /// Get CSV file as stream from a source and return it as a stream
    /// </summary>
    /// <returns>stream</returns>
    Task<Stream> GetCsvAsync();
}

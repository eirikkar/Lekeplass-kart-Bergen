namespace Lekeplass_kart_Bergen.Services;

public interface IFileFetcherService
{
    Task<Stream> GetCsvAsync();
}

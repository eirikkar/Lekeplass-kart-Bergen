namespace Lekeplass_kart_Bergen.Services;

public interface IFileFetcher
{
    Task<Stream> GetCsvAsync();
}

using Lekeplass_kart_Bergen.Models;

namespace Lekeplass_kart_Bergen.Services;

public interface ILekeplassService
{
    /// <summary>
    /// Get lekeplasser from stream, convert it from csv to the Lekeplass model and return a list of lekeplasser
    /// </summary>
    /// <param name="stream"></param>
    /// <returns>List</returns>
    List<Lekeplass> GetLekeplasser(Stream stream);
}

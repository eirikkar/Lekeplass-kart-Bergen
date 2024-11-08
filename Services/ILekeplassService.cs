using Lekeplass_kart_Bergen.Models;

namespace Lekeplass_kart_Bergen.Services;

public interface ILekeplassService
{
    IEnumerable<Lekeplass> GetLekeplasser(Stream stream);
}

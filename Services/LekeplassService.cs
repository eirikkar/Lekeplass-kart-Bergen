using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using Lekeplass_kart_Bergen.Models;

namespace Lekeplass_kart_Bergen.Services;

public class LekeplassService : ILekeplassService
{
    public List<Lekeplass> GetLekeplasser(Stream stream)
    {
        using var reader = new StreamReader(stream);
        var config = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" };
        using var csv = new CsvReader(reader, config);
        return csv.GetRecords<Lekeplass>().ToList();
    }
}

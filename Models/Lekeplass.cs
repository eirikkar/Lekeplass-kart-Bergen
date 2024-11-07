namespace Lekeplass_kart_Bergen.Models;

using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

class Lekeplass
{
    [Name("id")]
    public int Id { get; set; }

    [Name("navn")]
    public string? Name { get; set; }

    [Name("longitude")]
    public decimal Long { get; set; }

    [Name("latitude")]
    public decimal Lat { get; set; }

    public List<Lekeplass> GetLekeplasser()
    {
        using var reader = new StreamReader("data/lekeplasser.csv");
        var config = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" };
        using var csv = new CsvReader(reader, config);
        return csv.GetRecords<Lekeplass>().ToList();
    }
}

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

    public List<Lekeplass> StreamReader(Stream stream)
    {
        using var reader = new StreamReader(stream);
        var config = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" };
        using var csv = new CsvReader(reader, config);

        var records = csv.GetRecords<Lekeplass>().ToList();
        return records;
    }
}

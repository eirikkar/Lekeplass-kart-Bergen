namespace Lekeplass_kart_Bergen.Models;

using CsvHelper.Configuration.Attributes;

// Lekeplass model
public class Lekeplass
{
    [Name("id")]
    public int Id { get; set; }

    [Name("navn")]
    public string? Name { get; set; }

    [Name("longitude")]
    public decimal Long { get; set; }

    [Name("latitude")]
    public decimal Lat { get; set; }
}

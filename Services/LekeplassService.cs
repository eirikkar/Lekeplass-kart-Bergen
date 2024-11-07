using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using Lekeplass_kart_Bergen.Models;

namespace Lekeplass_kart_Bergen.Services
{
    public class LekeplassService : ILekeplassService
    {
        private readonly string filepath = "data/lekeplasser.csv";

        public IEnumerable<Lekeplass> GetLekeplasser()
        {
            using var reader = new StreamReader(filepath);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" };
            using var csv = new CsvReader(reader, config);
            return csv.GetRecords<Lekeplass>().ToList();
        }
    }
}

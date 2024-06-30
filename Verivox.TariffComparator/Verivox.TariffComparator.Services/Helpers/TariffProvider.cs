using Newtonsoft.Json;
using Verivox.TariffComparator.Models.Models;
using Verivox.TariffComparator.Service.Contracts;

namespace Verivox.TariffComparator.Service.Helpers;

public class TariffProvider : ITariffProvider
{
    public List<Tariff> GetTariffs(string path)
    {
        try
        {
            using (StreamReader r = new StreamReader(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, path)))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Tariff>>(json)??new List<Tariff>();
            }
        }
        catch (Exception) 
        { 
            throw;
        }
       
    }
}


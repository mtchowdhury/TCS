using Newtonsoft.Json;
using TCS.TariffComparator.Models.Models;
using TCS.TariffComparator.Service.Contracts;

namespace TCS.TariffComparator.Service.Helpers;

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


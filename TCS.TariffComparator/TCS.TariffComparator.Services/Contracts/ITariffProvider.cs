using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.TariffComparator.Models.Models;

namespace TCS.TariffComparator.Service.Contracts
{
    public interface ITariffProvider
    {
        List<Tariff> GetTariffs(string path);
    }
}

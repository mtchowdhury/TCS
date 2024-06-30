using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.TariffComparator.Models.Models;

namespace Verivox.TariffComparator.Service.Contracts
{
    public interface ITariffProvider
    {
        List<Tariff> GetTariffs(string path);
    }
}

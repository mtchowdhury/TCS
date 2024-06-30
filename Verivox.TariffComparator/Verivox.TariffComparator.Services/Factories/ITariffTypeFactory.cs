using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.TariffComparator.Models.Models;
using Verivox.TariffComparator.Service.Services.TariffCalculator;

namespace Verivox.TariffComparator.Service.Factories
{
    public interface ITariffTypeFactory
    {
        TariffType GetPlanFromTariff(Tariff tariff);
    }
}

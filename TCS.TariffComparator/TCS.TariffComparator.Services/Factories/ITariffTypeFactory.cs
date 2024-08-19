using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.TariffComparator.Models.Models;
using TCS.TariffComparator.Service.Services.TariffCalculator;

namespace TCS.TariffComparator.Service.Factories
{
    public interface ITariffTypeFactory
    {
        TariffType GetPlanFromTariff(Tariff tariff);
    }
}

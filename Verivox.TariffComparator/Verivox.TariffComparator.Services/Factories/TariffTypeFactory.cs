using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.TariffComparator.Models.Models;
using Verivox.TariffComparator.Service.Services.TariffCalculator;

namespace Verivox.TariffComparator.Service.Factories
{
    public class TariffTypeFactory : ITariffTypeFactory
    {
        public TariffType GetPlanFromTariff(Tariff tariff)
        {
            switch (tariff.Type)
            {
                case 1:
                    return new TariffTypeOne(tariff);
                case 2:
                    return new TariffTypeTwo(tariff);
                default:
                    return new TariffTypeDefault(tariff);
            }
        }
    }
}

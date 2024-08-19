using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.TariffComparator.Models.Models;
using TCS.TariffComparator.Service.Services.TariffCalculator;

namespace TCS.TariffComparator.Service.Factories
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.TariffComparator.Models.DTOs.Response;
using TCS.TariffComparator.Models.Models;

namespace TCS.TariffComparator.Service.Services.TariffCalculator
{
    public class TariffTypeDefault : TariffType
    {
        public TariffTypeDefault(Tariff tariff)
        {
            Tariff = tariff;
        }
        public override CalculationResult Calculate(int consumptionKwh)
        {
            return new CalculationResult { TariffName = Tariff.Name, Message = "Unknown Tariff Plan Type Provided" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.TariffComparator.Models.DTOs.Response;
using Verivox.TariffComparator.Models.Models;

namespace Verivox.TariffComparator.Service.Services.TariffCalculator
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.TariffComparator.Models.DTOs.Response;
using Verivox.TariffComparator.Models.Models;

namespace Verivox.TariffComparator.Service.Services.TariffCalculator
{
    public class TariffTypeTwo : TariffType
    {
        public TariffTypeTwo(Tariff tariff)
        {
            Tariff = tariff;
        }
        public override CalculationResult Calculate(int consumptionKwh)
        {
            decimal annualCost;
            if (consumptionKwh <= Tariff.IncludedKwh)
            {
                annualCost = Tariff.BaseCost;
            }
            else
            {
                annualCost = Tariff.BaseCost + (consumptionKwh - Tariff.IncludedKwh) * (Tariff.AdditionalKwhCost/100);
            }
            return new CalculationResult { TariffName = Tariff.Name, AnnualCost = annualCost, Message = $"Annual Cost For {Tariff.Name}" };
        }
    }
}

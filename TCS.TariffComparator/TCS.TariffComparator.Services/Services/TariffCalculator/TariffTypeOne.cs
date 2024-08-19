using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.TariffComparator.Models.DTOs.Response;
using TCS.TariffComparator.Models.Models;

namespace TCS.TariffComparator.Service.Services.TariffCalculator
{
    public class TariffTypeOne : TariffType
    {
        public TariffTypeOne(Tariff tariff)
        {
            Tariff =tariff;
        }
        public override CalculationResult Calculate(int consumptionKwh)
        {
            var annualCost = Tariff.BaseCost * 12 + consumptionKwh * (Tariff.AdditionalKwhCost/100);
            return new CalculationResult { TariffName = Tariff.Name, AnnualCost = annualCost, Message = $"Annual Cost For {Tariff.Name}" };
        }
    }
} 

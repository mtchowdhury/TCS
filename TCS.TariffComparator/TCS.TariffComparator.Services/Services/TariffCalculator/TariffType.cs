using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.TariffComparator.Models.DTOs.Response;
using TCS.TariffComparator.Models.Models;

namespace TCS.TariffComparator.Service.Services.TariffCalculator
{
    public abstract class TariffType
    {
        public Tariff Tariff { get; set; }
        public abstract CalculationResult Calculate(int consumptionKwh);
    }
}

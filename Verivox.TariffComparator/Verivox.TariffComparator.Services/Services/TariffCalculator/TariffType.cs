using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.TariffComparator.Models.DTOs.Response;
using Verivox.TariffComparator.Models.Models;

namespace Verivox.TariffComparator.Service.Services.TariffCalculator
{
    public abstract class TariffType
    {
        public Tariff Tariff { get; set; }
        public abstract CalculationResult Calculate(int consumptionKwh);
    }
}

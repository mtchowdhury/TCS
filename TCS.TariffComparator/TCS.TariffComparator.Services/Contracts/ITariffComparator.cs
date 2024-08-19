using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.TariffComparator.Models.DTOs.Response;
using TCS.TariffComparator.Models.Models;

namespace TCS.TariffComparator.Service.Contracts;

public interface ITariffComparator
    {
        List<CalculationResult> CalculateAnnualCosts(int consumptionKwh, List<Tariff> tariffs);
    }


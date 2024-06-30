using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.TariffComparator.Models.DTOs.Response;
using Verivox.TariffComparator.Models.Models;
using Verivox.TariffComparator.Service.Contracts;
using Verivox.TariffComparator.Service.Factories;
using Verivox.TariffComparator.Service.Services.TariffCalculator;

namespace Verivox.TariffComparator.Service.Services;

public class TariffComparator : ITariffComparator
{
    private readonly ITariffTypeFactory _tariffTypeFactory;
    public TariffComparator(ITariffTypeFactory tariffTypeFactory)
    {
        _tariffTypeFactory = tariffTypeFactory;
    }
    public List<CalculationResult> CalculateAnnualCosts(int consumptionKwh, List<Tariff> tariffs)
    {
        var allTariffPlans = tariffs.Select(t => _tariffTypeFactory.GetPlanFromTariff(t)) ;
        return allTariffPlans.Select(tp=> tp.Calculate(consumptionKwh)).OrderBy(r => r.AnnualCost).ToList();
    }
}


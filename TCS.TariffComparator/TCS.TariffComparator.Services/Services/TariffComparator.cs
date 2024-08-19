using TCS.TariffComparator.Models.DTOs.Response;
using TCS.TariffComparator.Models.Models;
using TCS.TariffComparator.Service.Contracts;
using TCS.TariffComparator.Service.Factories;

namespace TCS.TariffComparator.Service.Services;

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


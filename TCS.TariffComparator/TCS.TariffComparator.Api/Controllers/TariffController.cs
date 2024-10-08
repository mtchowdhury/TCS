﻿
using TCS.TariffComparator.Models.DTOs.Request;
using TCS.TariffComparator.Models.DTOs.Response;
using TCS.TariffComparator.Service.Contracts;
namespace TCS.TariffComparator.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TariffController : ControllerBase
{
    private readonly ITariffComparator _comparator;
    private readonly ITariffProvider _provider;
    private readonly IConfiguration _configuration;
    public TariffController(ITariffComparator comparator, IConfiguration configuration, ITariffProvider provider)
    {
        _comparator = comparator;
        _configuration = configuration;
        _provider = provider;
    }
    [HttpGet("getannualcost")]
    public ActionResult<List<CalculationResult>> GetAnnualCosts([FromQuery]TariffRequest consumption,CancellationToken ct)
    {
        var tariffs = _provider.GetTariffs(_configuration["TariffPath"]);
        var results = _comparator.CalculateAnnualCosts(consumption.ConsumptionUnit, tariffs);
        return Ok(results);
    }
}


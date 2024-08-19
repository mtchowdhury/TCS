using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.TariffComparator.Models.DTOs.Response;

public record CalculationResult
{
    public string TariffName { get; set; }
    public decimal? AnnualCost { get; set; }
    public string Message { get; set; }
}


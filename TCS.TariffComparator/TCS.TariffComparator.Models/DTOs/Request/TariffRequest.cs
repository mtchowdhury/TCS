using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.TariffComparator.Models.DTOs.Request
{
    public record TariffRequest
    {
        public int ConsumptionUnit { get; set; }
    }
}

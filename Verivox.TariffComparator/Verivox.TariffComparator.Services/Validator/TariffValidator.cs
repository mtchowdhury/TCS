using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verivox.TariffComparator.Models.DTOs.Request;

namespace Verivox.TariffComparator.Service.Validator
{
    public class TariffValidator : AbstractValidator<TariffRequest>
    {
        public TariffValidator()
        {
            RuleFor(v => v.ConsumptionUnit)
            .GreaterThan(-1)
            .WithMessage("consumption unit is require");
        }
      
    }
}

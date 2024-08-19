using FluentValidation;
using TCS.TariffComparator.Models.DTOs.Request;

namespace TCS.TariffComparator.Service.Validator
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

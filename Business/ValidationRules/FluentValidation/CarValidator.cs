using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(3);
            RuleFor(c => c.ModelYear).Must(GraterThanTwentyYear).WithMessage("Araç 20 yaşından büyük olmamalıdır");
        }

        private bool GraterThanTwentyYear(int arg)
        {
            if (arg<1990)
            {
                return false;
            }

            return true;
        }
    }
}

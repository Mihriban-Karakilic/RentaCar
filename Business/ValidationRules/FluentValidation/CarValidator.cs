using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelYear).MinimumLength(4).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(c => c.ModelYear).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Günlük kiralama ücreti 0 dan büyük olmalıdır");
        }
    }
}
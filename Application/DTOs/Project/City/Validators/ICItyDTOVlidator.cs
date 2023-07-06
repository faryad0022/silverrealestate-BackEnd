using Application.Const.Response;
using FluentValidation;

namespace Application.DTOs.Project.City.Validators
{
    public class ICItyDTOVlidator : AbstractValidator<ICityDTO>
    {
        public ICItyDTOVlidator()
        {
            RuleFor(x => x.CityName)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
            RuleFor(x => x.CountryId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);

        }
    }
}

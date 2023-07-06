using Application.Const.Response;
using FluentValidation;

namespace Application.DTOs.Project.Country.Validators
{
    public class ICountryDTOValidator : AbstractValidator<ICountryDTO>
    {
        public ICountryDTOValidator()
        {
            RuleFor(x => x.CountryName)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
        }
    }
}

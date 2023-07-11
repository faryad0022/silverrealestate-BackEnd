using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.Country.Validators
{
    public class ICountryDTOValidator : AbstractValidator<ICountryDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public ICountryDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            RuleFor(x => x.CountryName)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
        }
    }
}

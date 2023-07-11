using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.Country.Validators
{
    public class CreateCountryDTOValidator : AbstractValidator<CreateCountryDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public CreateCountryDTOValidator(IUnitofWork unitofWork)
        {
            Include(new ICountryDTOValidator(_unitofWork));
            RuleFor(x => x.CountryName)
                .MustAsync(async (countryName, token) =>
                {
                    return await _unitofWork.CountryRepository.CheckDuplicate(countryName);
                }).WithMessage(ValidatorMessages.Duplicate);
            _unitofWork = unitofWork;
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.Country.Validators
{
    public class UpdateCountryDTOValidator : AbstractValidator<UpdateCountryDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public UpdateCountryDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new ICountryDTOValidator());
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.CountryRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}

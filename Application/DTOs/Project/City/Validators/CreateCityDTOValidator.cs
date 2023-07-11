using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.City.Validators
{
    public class CreateCityDTOValidator : AbstractValidator<CreateCityDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public CreateCityDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new ICItyDTOVlidator(_unitofWork));
            RuleFor(x => x.CountryId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.CountryRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}

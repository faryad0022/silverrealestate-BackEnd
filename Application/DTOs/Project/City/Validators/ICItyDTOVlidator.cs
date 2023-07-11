using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.City.Validators
{
    public class ICItyDTOVlidator : AbstractValidator<ICityDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public ICItyDTOVlidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;

            RuleFor(x => x.CityName)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .MustAsync(async (cityName, token) =>
                {
                    return await _unitofWork.CityRepository.CheckDuplicateCity(cityName);
                }).WithMessage(ValidatorMessages.Duplicate);
            RuleFor(x => x.CountryId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}

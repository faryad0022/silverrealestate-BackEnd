using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.Facility.Validators
{
    public class IFacilityDTOValidator : AbstractValidator<IFacilityDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public IFacilityDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;

            RuleFor(x => x.FacilityName)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
            RuleFor(x => x.PropertyId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .MustAsync(async (id, token) =>
                {
                    if (id == 0) return false;
                    return await _unitofWork.PropertyRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}

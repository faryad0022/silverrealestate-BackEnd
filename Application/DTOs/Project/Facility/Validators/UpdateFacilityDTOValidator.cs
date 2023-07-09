using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.Facility.Validators
{
    public class UpdateFacilityDTOValidator : AbstractValidator<UpdateFacilityDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public UpdateFacilityDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new IFacilityDTOValidator(_unitofWork));
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.FacilityRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}

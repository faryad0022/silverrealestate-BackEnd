using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.Facility.Validators
{
    public class CreateFacilityDTOValidator : AbstractValidator<CreateFacilityDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public CreateFacilityDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new IFacilityDTOValidator());
            RuleFor(x => x.PropertyId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .MustAsync(async (id, token) =>
                {
                    if (id == 0) return false;
                    return await _unitofWork.PropertyRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}

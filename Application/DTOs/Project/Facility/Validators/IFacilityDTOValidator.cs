using Application.Const.Response;
using FluentValidation;

namespace Application.DTOs.Project.Facility.Validators
{
    public class IFacilityDTOValidator : AbstractValidator<IFacilityDTO>
    {
        public IFacilityDTOValidator()
        {
            RuleFor(x => x.FacilityName)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
            RuleFor(x => x.PropertyId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);

        }
    }
}

using Application.Const.Validator;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations.Validators
{
    public class ISpectacularLocationDTOValidator : AbstractValidator<ISpectacularLocationDTO>
    {
        public ISpectacularLocationDTOValidator()
        {
            RuleFor(s => s.Name)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
        }
    }
}

using Application.Const.Response;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Logo.Validator
{
    public class ILogoValidator : AbstractValidator<ILogoDTO>
    {
        public ILogoValidator()
        {
            RuleFor(x => x.Title)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.Description)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.ImageName)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
        }
    }
}

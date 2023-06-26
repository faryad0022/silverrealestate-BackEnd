using Application.Const.Response;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Social.Validators
{
    public class ISocialDTOValidator : AbstractValidator<ISocialDTO>
    {
        public ISocialDTOValidator()
        {
            RuleFor(x => x.Icon)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.Link)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.Name)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
        }
    }
}

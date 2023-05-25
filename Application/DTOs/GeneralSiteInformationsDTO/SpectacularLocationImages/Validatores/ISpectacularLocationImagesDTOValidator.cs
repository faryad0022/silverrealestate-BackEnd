using Application.Const.Validator;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages.Validatores
{
    public class ISpectacularLocationImagesDTOValidator : AbstractValidator<ISpectacularLocationImagesDTO>
    {
        public ISpectacularLocationImagesDTOValidator()
        {
            RuleFor(x => x.Text)
                .MinimumLength(5).WithMessage(ValidatorMessages.MinimumLength)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
            RuleFor(x => x.Image)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
            RuleFor(x => x.Description)
                .MinimumLength(5).WithMessage(ValidatorMessages.MinimumLength)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
            RuleFor(x => x.SpectacularlocationId)
                .GreaterThan(0).WithMessage(ValidatorMessages.MustSelected)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}

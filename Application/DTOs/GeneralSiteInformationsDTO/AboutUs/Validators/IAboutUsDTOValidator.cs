using Application.Const.Validator;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.AboutUs.Validators
{
    public class IAboutUsDTOValidator : AbstractValidator<IAboutusDTO>
    {
        public IAboutUsDTOValidator()
        {
            RuleFor(x => x.Text)
                .MaximumLength(1000).WithMessage(ValidatorMessages.MaximumLength)
                .MinimumLength(20).WithMessage(ValidatorMessages.MinimumLength)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}

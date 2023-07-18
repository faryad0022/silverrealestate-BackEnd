using Application.Const.Response;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.AboutUs.Validators
{
    public class IAboutUsDTOValidator : AbstractValidator<IAboutusDTO>
    {
        public IAboutUsDTOValidator()
        {
            RuleFor(x => x.Text)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}

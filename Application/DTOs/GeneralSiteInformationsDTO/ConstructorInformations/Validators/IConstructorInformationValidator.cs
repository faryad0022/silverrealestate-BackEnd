using Application.Const.Validator;
using FluentValidation;


namespace Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations.Validators
{
    public class IConstructorInformationValidator : AbstractValidator<IConstructorInformationDTO>
    {
        public IConstructorInformationValidator()
        {
            RuleFor(x => x.Title)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.ConstructorLogo)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.Description)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
        }
    }
}

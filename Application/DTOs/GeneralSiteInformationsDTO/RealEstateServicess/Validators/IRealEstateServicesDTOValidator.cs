using Application.Const.Validator;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess.Validators
{
    public class IRealEstateServicesDTOValidatorL : AbstractValidator<IRealEstateServicesDTO>
    {
        public IRealEstateServicesDTOValidatorL()
        {
            RuleFor(x => x.Name)
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

using Application.Const.Response;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Address.Validator
{
    public class IAddressValidator : AbstractValidator<IAddressDTO>
    {
        public IAddressValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress().WithMessage(ValidatorMessages.EmailFormat);
            RuleFor(x => x.Location)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}

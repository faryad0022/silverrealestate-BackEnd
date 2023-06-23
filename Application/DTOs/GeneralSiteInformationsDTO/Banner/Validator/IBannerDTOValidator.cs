using Application.Const.Validator;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Banner.Validator
{
    public class IBannerDTOValidator : AbstractValidator<IBannerDTO>
    {
        public IBannerDTOValidator()
        {
            RuleFor(x => x.BannerImage)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);

        }
    }
}

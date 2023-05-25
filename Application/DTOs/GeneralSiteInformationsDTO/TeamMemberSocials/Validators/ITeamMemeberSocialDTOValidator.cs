using Application.Const.Validator;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials.Validators
{
    public class ITeamMemeberSocialDTOValidator : AbstractValidator<ITeamMemberSocialDTO>
    {
        public ITeamMemeberSocialDTOValidator()
        {
            RuleFor(x => x.Icon)
                .NotNull().WithMessage(ValidatorMessages.NotEmpty)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.Name)
                .NotNull().WithMessage(ValidatorMessages.NotEmpty)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.Link)
                .NotNull().WithMessage(ValidatorMessages.NotEmpty)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.TeamMemberId)
                .GreaterThan(0).WithMessage(ValidatorMessages.MustSelected)
                .NotNull().WithMessage(ValidatorMessages.NotEmpty)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
        }
    }
}

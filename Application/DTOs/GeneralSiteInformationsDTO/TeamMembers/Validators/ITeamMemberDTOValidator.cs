using Application.Const.Validator;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMembers.Validators
{
    public class ITeamMemberDTOValidator : AbstractValidator<ITeamMemberDTO>
    {
        public ITeamMemberDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.MemberPicture)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.CellPhone)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.MemberPosition)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
            RuleFor(x => x.Email)
                .EmailAddress().WithMessage(ValidatorMessages.EmailFormat)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty);
        }
    }
}

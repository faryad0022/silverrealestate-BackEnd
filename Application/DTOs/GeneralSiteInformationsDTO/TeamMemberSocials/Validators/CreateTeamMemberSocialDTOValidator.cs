using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials.Validators
{
    public class CreateTeamMemberSocialDTOValidator : AbstractValidator<CreateTeamMemberSocialDTO>
    {
        public CreateTeamMemberSocialDTOValidator()
        {
            Include(new ITeamMemeberSocialDTOValidator());
        }
    }
}

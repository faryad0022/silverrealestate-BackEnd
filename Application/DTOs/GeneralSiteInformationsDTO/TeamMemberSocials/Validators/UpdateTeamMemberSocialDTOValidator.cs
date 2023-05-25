using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials.Validators
{
    public class UpdateTeamMemberSocialDTOValidator : AbstractValidator<UpdateTeamMemberSocialDTO>
    {
        public UpdateTeamMemberSocialDTOValidator()
        {
            Include(new ITeamMemeberSocialDTOValidator());
        }
    }
}

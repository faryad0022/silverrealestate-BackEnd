using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMembers.Validators
{
    public class UpdateTeamMemberValidator : AbstractValidator<UpdateTeamMemberDTO>
    {
        public UpdateTeamMemberValidator()
        {
            Include(new ITeamMemberDTOValidator());
        }
    }
}

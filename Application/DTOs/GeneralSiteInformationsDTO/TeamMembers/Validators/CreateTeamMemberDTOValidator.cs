using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMembers.Validators
{
    public class CreateTeamMemberDTOValidator : AbstractValidator<CreateTeamMmeberDTO>
    {
        public CreateTeamMemberDTOValidator()
        {
            Include(new ITeamMemberDTOValidator());
        }
    }
}

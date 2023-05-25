using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands
{
    public class CreateTeamMemberRequest : IRequest<ReturnData<TeamMemberDTO>>
    {
        public CreateTeamMmeberDTO createTeamMmeberDTO { get; set; }
    }
}

using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands
{
    public class UpdateTeamMemberRequest : IRequest<ReturnData<TeamMemberDTO>>
    {
        public UpdateTeamMemberDTO updateTeamMemberDTO { get; set; }
    }
}

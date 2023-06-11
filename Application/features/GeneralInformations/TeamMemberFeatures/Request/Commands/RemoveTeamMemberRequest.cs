using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands
{
    public class RemoveTeamMemberRequest : IRequest<ReturnData<TeamMemberDTO>>
    {
        public long Id { get; set; }
    }
}

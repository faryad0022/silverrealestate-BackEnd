using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands
{
    public class ChangeTeamMemberSelectedStatusRequest : IRequest<ReturnData<TeamMemberDTO>>
    {
        public long Id { get; set; }
    }
}

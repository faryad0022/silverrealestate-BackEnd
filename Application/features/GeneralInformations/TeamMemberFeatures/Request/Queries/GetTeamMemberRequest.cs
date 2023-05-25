using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries
{
    public class GetTeamMemberRequest : IRequest<ReturnData<TeamMemberDTO>>
    {
        public long Id { get; set; }
    }
}

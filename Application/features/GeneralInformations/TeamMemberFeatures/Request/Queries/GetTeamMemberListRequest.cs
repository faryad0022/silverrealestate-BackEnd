using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries
{
    public class GetTeamMemberListRequest : IRequest<ReturnData<TeamMemberDTO>>
    {
        public bool justSelected { get; set; }
    }
}

using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.Reaspose;
using MediatR;


namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries
{
    public class GetFilterTeamMemberRequest:IRequest<ReturnData<FilterTeamMemberDTO>>
    {
        public FilterTeamMemberDTO filter { get; set; }
    }
}

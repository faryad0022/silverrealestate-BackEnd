using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using MediatR;


namespace Application.features.PanelAndSiteFeatures.GeneralInformations.TeamMemberFeatures.Request.Queries
{
    public class GetFilterTeamMemberRequest : IRequest<ResponseResultDTO>
    {
        public FilterTeamMemberDTO filter { get; set; }
    }
}

using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.TeamMemberFeatures.Request.Queries
{
    public class GetTeamMemberListRequest : IRequest<ResponseResultDTO>
    {
        public bool justSelected { get; set; }
    }
}

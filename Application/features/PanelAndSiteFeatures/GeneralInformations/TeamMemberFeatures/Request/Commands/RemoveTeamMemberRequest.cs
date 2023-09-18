using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.TeamMemberFeatures.Request.Commands
{
    public class RemoveTeamMemberRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}

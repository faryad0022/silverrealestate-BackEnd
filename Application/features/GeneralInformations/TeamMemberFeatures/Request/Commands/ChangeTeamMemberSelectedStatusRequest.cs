using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands
{
    public class ChangeTeamMemberSelectedStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}

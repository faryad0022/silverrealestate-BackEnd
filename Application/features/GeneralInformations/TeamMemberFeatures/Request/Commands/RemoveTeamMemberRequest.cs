using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands
{
    public class RemoveTeamMemberRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}

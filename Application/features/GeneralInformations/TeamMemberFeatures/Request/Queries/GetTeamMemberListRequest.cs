using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries
{
    public class GetTeamMemberListRequest : IRequest<ResponseResult>
    {
        public bool justSelected { get; set; }
    }
}

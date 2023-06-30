using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries
{
    public class GetTeamMemberListRequest : IRequest<ResponseResultDTO>
    {
        public bool justSelected { get; set; }
    }
}

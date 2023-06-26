using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries
{
    public class GetTeamMemberRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}

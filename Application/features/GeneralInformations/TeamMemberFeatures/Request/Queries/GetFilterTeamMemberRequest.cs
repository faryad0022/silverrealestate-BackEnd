using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using MediatR;


namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries
{
    public class GetFilterTeamMemberRequest:IRequest<ResponseResult>
    {
        public FilterTeamMemberDTO filter { get; set; }
    }
}

using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using MediatR;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands
{
    public class ChangeTeamMemberSelectedStatusRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}

using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.PanelAndSiteFeatures.GeneralInformations.TeamMemberFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{

    public class TeamMemberController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public TeamMemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.TeamMember_GetAll, Name = "SiteGetAllTeamMembers")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllTeamMembers()
            => await _mediator.Send(new GetTeamMemberListRequest());

        [HttpGet(ApiRouteV1.TeamMember_GetFilter, Name = "SiteGetFiltereTeamMembers")]
        public async Task<ActionResult<ResponseResultDTO>> GetFiltereTeamMembers([FromQuery] FilterTeamMemberDTO filter)
            => await _mediator.Send(new GetFilterTeamMemberRequest() { filter = filter });

        [HttpGet(ApiRouteV1.TeamMember_Get, Name = "SiteGetTeamMember")]
        public async Task<ActionResult<ResponseResultDTO>> GetTeamMember([FromQuery] long Id)
            => await _mediator.Send(new GetTeamMemberRequest() { Id = Id });

    }
}

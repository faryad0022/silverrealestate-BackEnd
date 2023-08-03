using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{

    public class TeamMemberController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public TeamMemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.TeamMember_GetAll, Name = "GetAllTeamMembers")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllTeamMembers()
            => await _mediator.Send(new GetTeamMemberListRequest());

        [HttpGet(ApiRouteV1.TeamMember_GetFilter, Name = "GetFiltereTeamMembers")]
        public async Task<ActionResult<ResponseResultDTO>> GetFiltereTeamMembers([FromQuery] FilterTeamMemberDTO filter)
            => await _mediator.Send(new GetFilterTeamMemberRequest() { filter = filter });

        [HttpGet(ApiRouteV1.TeamMember_Get, Name = "GetTeamMember")]
        public async Task<ActionResult<ResponseResultDTO>> GetTeamMember([FromQuery] long Id)
            => await _mediator.Send(new GetTeamMemberRequest() { Id = Id });

        [HttpPost(ApiRouteV1.TeamMember_Add, Name = "AddTeamMember")]
        public async Task<ActionResult<ResponseResultDTO>> AddTeamMember([FromBody] CreateTeamMmeberDTO teammemberDTO)
            => await _mediator.Send(new CreateTeamMemberRequest() { createTeamMmeberDTO = teammemberDTO });

        [HttpPut(ApiRouteV1.TeamMember_ChangeStatus, Name = "ChangeTeamMemberStatus")]
        public async Task<ActionResult<ResponseResultDTO>> ChangeTeamMemberStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeTeamMemberSelectedStatusRequest() { Id = Id });

        [HttpPut(ApiRouteV1.TeamMember_Update, Name = "UpdateTeamMember")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateTeamMember([FromBody] UpdateTeamMemberDTO updateTeamMemberDTO)
            => await _mediator.Send(new UpdateTeamMemberRequest() { updateTeamMemberDTO = updateTeamMemberDTO });
        [HttpPut(ApiRouteV1.TeamMember_Delete, Name = "DeleteTeamMember")]
        public async Task<ActionResult<ResponseResultDTO>> DeleteTeamMember([FromBody] long id)
            => await _mediator.Send(new RemoveTeamMemberRequest() { Id = id });
    }
}

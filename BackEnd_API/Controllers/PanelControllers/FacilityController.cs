using Application.Const.Response;
using Application.DTOs.Project.Facility;
using Application.features.PanelAndSiteFeatures.Projects.FacilityFeatures.Request.Commands;
using Application.features.PanelAndSiteFeatures.Projects.FacilityFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    [Authorize]

    public class FacilityController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public FacilityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.Facility_GetAll, Name = "GetAllFacilitys")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllFacilitys()
            => await _mediator.Send(new GetFacilityListRequest());


        [HttpGet(ApiRouteV1.Facility_Get, Name = "GetFacility")]
        public async Task<ActionResult<ResponseResultDTO>> GetFacility([FromQuery] long Id)
            => await _mediator.Send(new GetFacilityRequest() { Id = Id });

        [HttpPost(ApiRouteV1.Facility_Add, Name = "AddFacility")]
        public async Task<ActionResult<ResponseResultDTO>> AddFacility([FromBody] CreateFacilityDTO createFacilityDTO)
            => await _mediator.Send(new CreateFacilityRequest() { createFacilityDTO = createFacilityDTO });


        [HttpPut(ApiRouteV1.Facility_Update, Name = "UpdateFacility")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateFacility([FromBody] UpdateFacilityDTO updateFacilityDTO)
            => await _mediator.Send(new UpdateFacilityRequest() { updateFacilityDTO = updateFacilityDTO });


        [HttpPut(ApiRouteV1.Facility_Delete, Name = "DeleteFacility")]
        public async Task<ActionResult<ResponseResultDTO>> DeleteFacility([FromBody] long id)
            => await _mediator.Send(new DeleteFacilityRequest() { Id = id });
    }
}

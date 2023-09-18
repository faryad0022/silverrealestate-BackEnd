using Application.Const.Response;
using Application.DTOs.Project.PropertyPlans;
using Application.features.PanelAndSiteFeatures.Projects.PropertyPlanFeatures.Request.Commands;
using Application.features.PanelAndSiteFeatures.Projects.PropertyPlanFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{

    public class PropertyPlanController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public PropertyPlanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.PropertyPlan_GetAll, Name = "GetAllPropertyPlans")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllPropertyPlans([FromQuery] long propertyId)
            => await _mediator.Send(new GetPropertyPlanListRequest() { PropertyId = propertyId });


        [HttpGet(ApiRouteV1.PropertyPlan_Get, Name = "GetPropertyPlan")]
        public async Task<ActionResult<ResponseResultDTO>> GetPropertyPlan([FromQuery] long Id)
            => await _mediator.Send(new GetPropertyPlanRequest() { Id = Id });

        [HttpPost(ApiRouteV1.PropertyPlan_Add, Name = "AddPropertyPlan")]
        public async Task<ActionResult<ResponseResultDTO>> AddPropertyPlan([FromBody] CreatePropertyPlanDTO createPropertyPlanDTO)
            => await _mediator.Send(new CreatePropertyPlanRequest() { createPropertyPlanDTO = createPropertyPlanDTO });


        [HttpPut(ApiRouteV1.PropertyPlan_Update, Name = "UpdatePropertyPlan")]
        public async Task<ActionResult<ResponseResultDTO>> UpdatePropertyPlan([FromBody] UpdatePropertyPlanDTO updatePropertyPlanDTO)
            => await _mediator.Send(new UpdatePropertyPlanRequest() { updatePropertyPlanDTO = updatePropertyPlanDTO });


        [HttpPut(ApiRouteV1.PropertyPlan_Delete, Name = "DeletePropertyPlan")]
        public async Task<ActionResult<ResponseResultDTO>> DeletePropertyPlan([FromBody] long id)
            => await _mediator.Send(new DeletePropertyPlanRequest() { Id = id });
    }
}

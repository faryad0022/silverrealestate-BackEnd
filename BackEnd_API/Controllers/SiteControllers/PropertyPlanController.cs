using Application.Const.Response;
using Application.DTOs.Project.PropertyPlans;
using Application.features.Projects.PropertyPlanFeatures.Request.Commands;
using Application.features.Projects.PropertyPlanFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{

    public class PropertyPlanController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public PropertyPlanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.PropertyPlan_GetAll, Name = "SiteGetAllPropertyPlans")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllPropertyPlans([FromQuery] long propertyId)
            => await _mediator.Send(new GetPropertyPlanListRequest() { PropertyId= propertyId });


        [HttpGet(ApiRouteV1.PropertyPlan_Get, Name = "SiteGetPropertyPlan")]
        public async Task<ActionResult<ResponseResultDTO>> GetPropertyPlan([FromQuery] long Id)
            => await _mediator.Send(new GetPropertyPlanRequest() { Id = Id });


    }
}

using Application.Const.Response;
using Application.features.PanelAndSiteFeatures.Projects.PropertyTypeFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{
    public class PropertyTypeController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public PropertyTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.PropertyType_GetAll, Name = "SiteGetAllPropertyTypes")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllPropertyTypes()
            => await _mediator.Send(new GetPropertyTypeListRequest());


        [HttpGet(ApiRouteV1.PropertyType_Get, Name = "SiteGetPropertyType")]
        public async Task<ActionResult<ResponseResultDTO>> GetPropertyType([FromQuery] long Id)
            => await _mediator.Send(new GetPropertyTypeRequest() { Id = Id });


    }
}

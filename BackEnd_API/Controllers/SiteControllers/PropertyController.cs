using Application.Const.Response;
using Application.DTOs.Project.PropertDTOs;
using Application.features.Projects.PropertyFeatures.Request.Commands;
using Application.features.Projects.PropertyFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{
    public class PropertyController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public PropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.Property_GetAll, Name = "SiteGetAllProperties")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllProperties()
            => await _mediator.Send(new GetPropertyListWithDetailsRequest());


        [HttpGet(ApiRouteV1.Property_GetFilter, Name = "SiteGetFilterProperties")]
        public async Task<ActionResult<ResponseResultDTO>> GetFilterProperties([FromQuery] FilterPropertyDTO filterDTO)
            => await _mediator.Send(new GetFilterPropertyRequest() { filterDTO = filterDTO });

        [HttpGet(ApiRouteV1.Property_Get, Name = "SiteGetProperty")]
        public async Task<ActionResult<ResponseResultDTO>> GetProperty([FromBody] long Id)
            => await _mediator.Send(new GetPropertyWithDetailsRequest() { Id = Id });


    }
}

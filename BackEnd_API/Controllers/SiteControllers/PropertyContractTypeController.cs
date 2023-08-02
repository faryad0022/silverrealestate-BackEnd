using Application.Const.Response;
using Application.DTOs.Project.PropertyContractType;
using Application.features.Projects.PropertyContractTypeFeatures.Request.Commands;
using Application.features.Projects.PropertyContractTypeFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{
    public class PropertyContractTypeController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public PropertyContractTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.PropertyContractType_GetAll, Name = "SiteGetAllPropertyContractTypes")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllPropertyContractTypes()
            => await _mediator.Send(new GetPropertyContractTypeListRequest());


        [HttpGet(ApiRouteV1.PropertyContractType_Get, Name = "SiteGetPropertyContractType")]
        public async Task<ActionResult<ResponseResultDTO>> GetPropertyContractType([FromQuery] long Id)
            => await _mediator.Send(new GetPropertyContractTypeRequest() { Id = Id });


    }
}

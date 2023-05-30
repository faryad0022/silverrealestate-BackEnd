using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.features.GeneralInformations.ConstructorInformations.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{
    public class ConstructorInformationController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public ConstructorInformationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.ConstructorInformation_GetAll,Name ="GetAllConstructorInformationAsync")]
        public async Task<ActionResult<ReturnData<ConstructorInformationDTO>>> GetAllConstructor()
            => await _mediator.Send(new GetConstructorInformationListRequest() { justShowSelected=true});
    }
}

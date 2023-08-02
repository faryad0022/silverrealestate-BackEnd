using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{

    public class RealEstateServiceController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public RealEstateServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.RealEstateServicc_GetAll, Name = "SiteGetAllRealEstateService")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllRealEstateService()
            => await _mediator.Send(new GetRealEstateServiceListRequest());

        [HttpGet(ApiRouteV1.RealEstateServicc_Get, Name = "SiteGetRealEstateService")]
        public async Task<ActionResult<ResponseResultDTO>> GetRealEstateService([FromQuery] long Id)
            => await _mediator.Send(new GetRealEstateServiceRequest() { Id = Id });

    }
}

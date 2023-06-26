using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class RealEstateServiceController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public RealEstateServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.RealEstateServicc_GetAll,Name = "GetAllRealEstateService")]
        public async Task<ActionResult<ResponseResult>> GetAllRealEstateService()
            => await _mediator.Send(new GetRealEstateServiceListRequest());

        [HttpGet(ApiRouteV1.RealEstateServicc_Get, Name = "GetRealEstateService")]
        public async Task<ActionResult<ResponseResult>> GetRealEstateService([FromQuery] long Id)
            => await _mediator.Send(new GetRealEstateServiceRequest() { Id = Id });

        [HttpPost(ApiRouteV1.RealEstateServicc_Add, Name = "AddRealEstateService")]
        public async Task<ActionResult<ResponseResult>> AddRealEstateService([FromBody] CreateRealEstateServicesDTO createRealEstateServicesDTO)
            => await _mediator.Send(new CreateRealEstateServicesRequest() { createRealEstateServicesDTO = createRealEstateServicesDTO });

        [HttpPut(ApiRouteV1.RealEstateServicc_Update, Name = "UpdateRealEstateService")]
        public async Task<ActionResult<ResponseResult>> UpdateRealEstateService([FromQuery] UpdateRealEstateServicesDTO updateRealEstateServicesDTO)
            => await _mediator.Send(new UpdateRealEstateServicesRequest() { updateRealEstateServicesDTO = updateRealEstateServicesDTO });

        [HttpPut(ApiRouteV1.RealEstateServicc_ChangeStatus, Name = "ChangeRealEstateServiceStatus")]
        public async Task<ActionResult<ResponseResult>> ChangeRealEstateServiceStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeRealEstateServiceSelectedStatusRequest() { Id = Id });
    }
}

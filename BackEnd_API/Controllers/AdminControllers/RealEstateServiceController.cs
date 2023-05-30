using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries;
using Application.Reaspose;
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
        [HttpGet(ApiRouteV1.RealEstateServicc_GetAll)]
        public async Task<ActionResult<ReturnData<RealEstateServicesDTO>>> GetAllRealEstateService()
            => await _mediator.Send(new GetRealEstateServiceListRequest());

        [HttpGet(ApiRouteV1.RealEstateServicc_Get)]
        public async Task<ActionResult<ReturnData<RealEstateServicesDTO>>> GetRealEstateService([FromQuery] long Id)
            => await _mediator.Send(new GetRealEstateServiceRequest() { Id = Id });

        [HttpPost(ApiRouteV1.RealEstateServicc_Add)]
        public async Task<ActionResult<ReturnData<CreateRealEstateServicesDTO>>> AddRealEstateService([FromBody] CreateRealEstateServicesDTO createRealEstateServicesDTO)
            => await _mediator.Send(new CreateRealEstateServicesRequest() { createRealEstateServicesDTO = createRealEstateServicesDTO });

        [HttpPut(ApiRouteV1.RealEstateServicc_Update)]
        public async Task<ActionResult<ReturnData<UpdateRealEstateServicesDTO>>> UpdateRealEstateService([FromQuery] UpdateRealEstateServicesDTO updateRealEstateServicesDTO)
            => await _mediator.Send(new UpdateRealEstateServicesRequest() { updateRealEstateServicesDTO = updateRealEstateServicesDTO });

        [HttpPut(ApiRouteV1.RealEstateServicc_ChangeStatus)]
        public async Task<ActionResult<ReturnData<RealEstateServicesDTO>>> ChangeRealEstateServiceStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeRealEstateServiceSelectedStatusRequest() { Id = Id });
    }
}

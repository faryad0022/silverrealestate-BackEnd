using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries;
using Application.Reaspose;
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
        [HttpGet("get-all-real-estate-service")]
        public async Task<ActionResult<ReturnData<RealEstateServicesDTO>>> GetAllRealEstateService()
            => await _mediator.Send(new GetRealEstateServiceListRequest());

        [HttpGet("get-real-estate-service")]
        public async Task<ActionResult<ReturnData<RealEstateServicesDTO>>> GetRealEstateService([FromQuery] long Id)
            => await _mediator.Send(new GetRealEstateServiceRequest() { Id = Id });

        [HttpPost("add-real-estate-service-")]
        public async Task<ActionResult<ReturnData<CreateRealEstateServicesDTO>>> AddRealEstateService([FromBody] CreateRealEstateServicesDTO createRealEstateServicesDTO)
            => await _mediator.Send(new CreateRealEstateServicesRequest() { createRealEstateServicesDTO = createRealEstateServicesDTO });

        [HttpPut("update-real-estate-service")]
        public async Task<ActionResult<ReturnData<UpdateRealEstateServicesDTO>>> UpdateRealEstateService([FromQuery] UpdateRealEstateServicesDTO updateRealEstateServicesDTO)
            => await _mediator.Send(new UpdateRealEstateServicesRequest() { updateRealEstateServicesDTO = updateRealEstateServicesDTO });

        [HttpPut("change-real-estate-service-status")]
        public async Task<ActionResult<ReturnData<RealEstateServicesDTO>>> ChangeRealEstateServiceStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeRealEstateServiceSelectedStatusRequest() { Id = Id });
    }
}

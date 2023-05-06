using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.features.GeneralInformations.AddressFeatures.Request.Commands;
using Application.features.GeneralInformations.AddressFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers
{
    public class AddressController : SiteBaseController
    {
        private readonly IMediator _mediator;
        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-all-address")]
        public async Task<ActionResult<ReturnData<AddressDTO>>> GetAllAddress()
            => await _mediator.Send(new GetAddressListRequest());

        [HttpGet("get-address")]
        public async Task<ActionResult<ReturnData<AddressDTO>>> GetAddress([FromQuery] long Id)
            => await _mediator.Send(new GetAddressRequest() { Id=Id});

        [HttpPost("add-address")]
        public async Task<ActionResult<ReturnData<CreateAddressDTO>>> AddAddress([FromBody] CreateAddressDTO addressDTO)
            => await _mediator.Send(new CreateAddressRequest() {  createAddressDTO = addressDTO });

        [HttpPut("update-address")]
        public async Task<ActionResult<ReturnData<UpdateAddressDTO>>> UpdateAddress([FromQuery] UpdateAddressDTO addressDTO)
            => await _mediator.Send(new UpdateAddressRequest() { updateAddressDTO = addressDTO });

        [HttpPut("change-address-status")]
        public async Task<ActionResult<ReturnData<UpdateAddressDTO>>> ChangeAddressStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeAddressDTOStatusRequest() {  Id = Id });
    }
}

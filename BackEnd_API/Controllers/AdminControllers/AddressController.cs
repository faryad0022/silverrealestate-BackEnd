using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.features.GeneralInformations.AddressFeatures.Request.Commands;
using Application.features.GeneralInformations.AddressFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{
    public class AddressController : AdminBaseController
    {
        private readonly IMediator _mediator;
        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.Address_GetAll, Name = "GetAllAddress")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllAddress()
            => await _mediator.Send(new GetAddressListRequest());

        [HttpGet(ApiRouteV1.Address_Get, Name = "GetAddress")]
        public async Task<ActionResult<ResponseResultDTO>> GetAddress([FromQuery] long Id)
            => await _mediator.Send(new GetAddressRequest() { Id = Id });

        [HttpPost(ApiRouteV1.Address_Add, Name = "AddAddress")]
        public async Task<ActionResult<ResponseResultDTO>> AddAddress([FromBody] CreateAddressDTO addressDTO)
            => await _mediator.Send(new CreateAddressRequest() { createAddressDTO = addressDTO });

        [HttpPut(ApiRouteV1.Address_Update, Name = "UpdateAddress")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateAddress([FromBody] UpdateAddressDTO addressDTO)
            => await _mediator.Send(new UpdateAddressRequest() { updateAddressDTO = addressDTO });

        [HttpPut(ApiRouteV1.Address_Delete, Name = "DeleteAddress")]
        public async Task<ActionResult<ResponseResultDTO>> DeleteAddress([FromBody] long Id)
    => await _mediator.Send(new DeleteAddressRequest() { Id = Id });

        [HttpPut(ApiRouteV1.Address_ChangeStatus, Name = "ChangeAddressStatus")]
        public async Task<ActionResult<ResponseResultDTO>> ChangeAddressStatus([FromBody] long Id)
            => await _mediator.Send(new ChangeAddressDTOStatusRequest() { Id = Id });
    }
}

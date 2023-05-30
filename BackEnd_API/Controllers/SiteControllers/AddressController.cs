using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.features.GeneralInformations.AddressFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd_API.Controllers.SiteControllers
{
    public class AddressController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.Address_GetAll,Name ="GetAllAddressAsync")]
        public async Task<ActionResult<ReturnData<AddressDTO>>> GetAll()
            => await _mediator.Send(new GetAddressListRequest() { justShowSelected = true });

        [HttpGet(ApiRouteV1.Address_Get,Name ="GetAddressAsync")]
        public async Task<ActionResult<ReturnData<AddressDTO>>> GetById()
            => await _mediator.Send(new GetAddressRequest());

    }
}

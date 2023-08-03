using Application.Const.Response;
using Application.DTOs.Project.City;
using Application.features.Projects.CityFeatures.Request.Commands;
using Application.features.Projects.CityFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    public class CityController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public CityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.City_GetCityListOfCountry, Name = "GetCityListOfCountry")]
        public async Task<ActionResult<ResponseResultDTO>> GetCityListOfCountry([FromQuery] long countryId)
            => await _mediator.Send(new GetCityListOfCountryRequest() { countryId = countryId });

        [HttpGet(ApiRouteV1.City_GetCityList_WithDetails, Name = "GetCityListWithDetails")]
        public async Task<ActionResult<ResponseResultDTO>> GetCityListWithDetails()
            => await _mediator.Send(new GetCityListWithDetailsRequest());

        [HttpGet(ApiRouteV1.City_GetCityListOfCountry_WithDetails, Name = "GetCityListOfCountryWithDetailsAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetCityListOfCountryWithDetailsAsync([FromQuery] long countryId)
            => await _mediator.Send(new GetCityListOfCountryWithDetailsRequest() { countryId = countryId });

        [HttpGet(ApiRouteV1.City_Get, Name = "GetCity")]
        public async Task<ActionResult<ResponseResultDTO>> GetCity([FromQuery] long Id)
            => await _mediator.Send(new GetCityRequest() { Id = Id });

        [HttpGet(ApiRouteV1.City_GetWithDetails, Name = "GetCityWithDetailsAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetCityWithDetailsAsync([FromQuery] long Id)
            => await _mediator.Send(new GetCityWithDetailsRequest() { cityId = Id });

        [HttpPost(ApiRouteV1.City_Add, Name = "AddCity")]
        public async Task<ActionResult<ResponseResultDTO>> AddCity([FromBody] CreateCityDTO createCityDTO)
            => await _mediator.Send(new CreateCityRequest() { createCityDTO = createCityDTO });


        [HttpPut(ApiRouteV1.City_Update, Name = "UpdateCity")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateCity([FromBody] UpdateCityDTO updateCityDTO)
            => await _mediator.Send(new UpdateCityRequest() { updateCityDTO = updateCityDTO });


        [HttpPut(ApiRouteV1.City_Delete, Name = "DeleteCity")]
        public async Task<ActionResult<ResponseResultDTO>> DeleteCity([FromBody] long id)
            => await _mediator.Send(new DeleteCityRequest() { Id = id });
    }
}

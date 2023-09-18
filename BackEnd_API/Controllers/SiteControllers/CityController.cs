using Application.Const.Response;
using Application.features.PanelAndSiteFeatures.Projects.CityFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{
    public class CityController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public CityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.City_GetCityListOfCountry, Name = "SiteGetCityListOfCountry")]
        public async Task<ActionResult<ResponseResultDTO>> GetCityListOfCountry([FromQuery] long countryId)
            => await _mediator.Send(new GetCityListOfCountryRequest() { countryId = countryId });

        [HttpGet(ApiRouteV1.City_GetCityList_WithDetails, Name = "SiteGetCityListWithDetails")]
        public async Task<ActionResult<ResponseResultDTO>> GetCityListWithDetails()
            => await _mediator.Send(new GetCityListWithDetailsRequest());

        [HttpGet(ApiRouteV1.City_GetCityListOfCountry_WithDetails, Name = "SiteGetCityListOfCountryWithDetailsAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetCityListOfCountryWithDetailsAsync([FromQuery] long countryId)
            => await _mediator.Send(new GetCityListOfCountryWithDetailsRequest() { countryId = countryId });

        [HttpGet(ApiRouteV1.City_Get, Name = "SiteGetCity")]
        public async Task<ActionResult<ResponseResultDTO>> GetCity([FromQuery] long Id)
            => await _mediator.Send(new GetCityRequest() { Id = Id });

        [HttpGet(ApiRouteV1.City_GetWithDetails, Name = "SiteGetCityWithDetailsAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetCityWithDetailsAsync([FromQuery] long Id)
            => await _mediator.Send(new GetCityWithDetailsRequest() { cityId = Id });

    }
}

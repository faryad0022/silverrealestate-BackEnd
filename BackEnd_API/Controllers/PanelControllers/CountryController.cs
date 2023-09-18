using Application.Const.Response;
using Application.DTOs.Project.Country;
using Application.features.PanelAndSiteFeatures.Projects.CountryFeatures.Request.Commands;
using Application.features.PanelAndSiteFeatures.Projects.CountryFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    [Authorize]

    public class CountryController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.Country_GetAll, Name = "GetAllCountries")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllCountrys()
            => await _mediator.Send(new GetCountryListRequest());


        [HttpGet(ApiRouteV1.Country_Get, Name = "GetCountry")]
        public async Task<ActionResult<ResponseResultDTO>> GetCountry([FromQuery] long Id)
            => await _mediator.Send(new GetCountryRequest() { Id = Id });

        [HttpPost(ApiRouteV1.Country_Add, Name = "AddCountry")]
        public async Task<ActionResult<ResponseResultDTO>> AddCountry([FromBody] CreateCountryDTO createCountryDTO)
            => await _mediator.Send(new CreateCountryRequest() { createCountryDTO = createCountryDTO });


        [HttpPut(ApiRouteV1.Country_Update, Name = "UpdateCountry")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateCountry([FromBody] UpdateCountryDTO updateCountryDTO)
            => await _mediator.Send(new UpdateCountryRequest() { updateCountryDTO = updateCountryDTO });


        [HttpPut(ApiRouteV1.Country_Delete, Name = "DeleteCountry")]
        public async Task<ActionResult<ResponseResultDTO>> DeleteCountry([FromBody] long id)
            => await _mediator.Send(new DeleteCountryRequest() { Id = id });
    }
}

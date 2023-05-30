using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Commands;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class AboutUsController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public AboutUsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.AboutUs_GetAll)]
        public async Task<ActionResult<ReturnData<AboutUsDTO>>> GetAboutUsListAsync()
            => await _mediator.Send(new GetAboutUsListRequest());


        [HttpGet(ApiRouteV1.AboutUs_Get)]
        public async Task<ActionResult<ReturnData<AboutUsDTO>>> GetAboutUsAsync([FromQuery] long Id)
            => await _mediator.Send(new GetAboutUsRequest { Id = Id });


        [HttpPost(ApiRouteV1.AboutUs_Add)]
        public async Task<ActionResult<ReturnData<CreateAboutUsDTO>>> AddAboutusAsync([FromBody] CreateAboutUsDTO aboutUsDTO)
            => await _mediator.Send(new CreateAboutUsRequest { createAboutUsDTO = aboutUsDTO });


        [HttpPut(ApiRouteV1.AboutUs_Update)]
        public async Task<ActionResult<ReturnData<UpdateAboutUsDTO>>> UpdateAboutusAsync([FromQuery] UpdateAboutUsDTO aboutUsDTO)
            => await _mediator.Send(new UpdateAboutUsRequest { updateAboutUsDTO = aboutUsDTO });
    }
}

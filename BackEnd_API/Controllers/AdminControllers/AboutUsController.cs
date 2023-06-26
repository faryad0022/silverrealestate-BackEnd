using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Commands;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Queries;
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
        [HttpGet(ApiRouteV1.AboutUs_GetAll,Name = "GetAboutUsListAsync")]
        public async Task<ActionResult<ResponseResult>> GetAboutUsListAsync()
            =>  await _mediator.Send(new GetAboutUsListRequest());


        [HttpGet(ApiRouteV1.AboutUs_Get, Name = "GetAboutUsAsync")]
        public async Task<ActionResult<ResponseResult>> GetAboutUsAsync([FromQuery] long Id)
            => await _mediator.Send(new GetAboutUsRequest { Id = Id });


        [HttpPost(ApiRouteV1.AboutUs_Add, Name = "AddAboutusAsync")]
        public async Task<ActionResult<ResponseResult>> AddAboutusAsync([FromBody] CreateAboutUsDTO aboutUsDTO)
            => await _mediator.Send(new CreateAboutUsRequest { createAboutUsDTO = aboutUsDTO });


        [HttpPut(ApiRouteV1.AboutUs_Update, Name = "UpdateAboutusAsync")]
        public async Task<ActionResult<ResponseResult>> UpdateAboutusAsync([FromQuery] UpdateAboutUsDTO aboutUsDTO)
            => await _mediator.Send(new UpdateAboutUsRequest { updateAboutUsDTO = aboutUsDTO });
    }
}

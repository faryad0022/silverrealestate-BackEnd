using Application.Const.Response;
using Application.features.PanelAndSiteFeatures.GeneralInformations.AboutUsFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{
    public class AboutUsController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public AboutUsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.AboutUs_GetAll, Name = "SiteGetAboutUsListAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetAboutUsListAsync()
            => await _mediator.Send(new GetAboutUsListRequest());


        [HttpGet(ApiRouteV1.AboutUs_Get, Name = "SiteGetAboutUsAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetAboutUsAsync([FromQuery] long Id)
            => await _mediator.Send(new GetAboutUsRequest { Id = Id });

    }
}

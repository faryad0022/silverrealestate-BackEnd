using Application.Const.Response;
using Application.features.PanelAndSiteFeatures.GeneralInformations.AboutUsFeatures.Request.Queries;
using Application.features.Site.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{
    public class HomeController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.HomePage, Name = "SiteHomeData")]
        public async Task<ActionResult<ResponseResultDTO>> GetHomeDTOsAsync()
            => await _mediator.Send(new GetHomeDTOsRequest());
    }
}

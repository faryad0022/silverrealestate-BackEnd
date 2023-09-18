using Application.Const.Response;
using Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{

    public class BannerController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public BannerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.Banner_GetAll, Name = "SiteGetAllBannerAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetAll()
            => await _mediator.Send(new GetBannerListRequest() { justShowSelected = true });

    }
}

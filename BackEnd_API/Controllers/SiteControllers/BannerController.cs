using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.GeneralInformations.BannerFeatures.Request.Queries;
using Application.Reaspose;
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
        [HttpGet(ApiRouteV1.Banner_GetAll, Name = "GetAllBannerAsync")]
        public async Task<ActionResult<ReturnData<BannerDTO>>> GetAll()
            => await _mediator.Send(new GetBannerListRequest() { justShowSelected = true });

    }
}

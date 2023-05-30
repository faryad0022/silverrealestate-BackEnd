using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.GeneralInformations.BannerFeatures.Request.Commands;
using Application.features.GeneralInformations.BannerFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class BannerController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public BannerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.Banner_GetAll)]
        public async Task<ActionResult<ReturnData<BannerDTO>>> GetAllBanner()
            => await _mediator.Send(new GetBannerListRequest());

        [HttpGet(ApiRouteV1.Banner_Get)]
        public async Task<ActionResult<ReturnData<BannerDTO>>> GetBanner([FromQuery] long Id)
            => await _mediator.Send(new GetBannerRequest() { Id = Id });

        [HttpPost(ApiRouteV1.Banner_Add)]
        public async Task<ActionResult<ReturnData<CreateBannerDTO>>> AddBanner([FromBody] CreateBannerDTO bannerDTO)
            => await _mediator.Send(new CreateBannerRequest() { createBannerDTO = bannerDTO });

        [HttpPut(ApiRouteV1.Banner_ChangeStatus)]
        public async Task<ActionResult<ReturnData<UpdateBannerDTO>>> ChangeBannerStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeBannerSelectedStatusRequest() { Id = Id });
    }
}

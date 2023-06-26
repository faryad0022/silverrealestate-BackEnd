using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.GeneralInformations.BannerFeatures.Request.Commands;
using Application.features.GeneralInformations.BannerFeatures.Request.Queries;
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
        [HttpGet(ApiRouteV1.Banner_GetFilter,Name = "GetFilterBanner")]
        public async Task<ActionResult<ResponseResult>> GetFilterBanner([FromQuery]FilterBannerDTO filter)
            => await _mediator.Send(new GetFilterBannerRequest() { filter = filter});

        [HttpGet(ApiRouteV1.Banner_GetAll, Name = "GetAllBanner")]
        public async Task<ActionResult<ResponseResult>> GetAllBanner()
            => await _mediator.Send(new GetBannerListRequest());

        [HttpGet(ApiRouteV1.Banner_Get, Name = "GetBanner")]
        public async Task<ActionResult<ResponseResult>> GetBanner([FromBody] long Id)
            => await _mediator.Send(new GetBannerRequest() { Id = Id });

        [HttpPost(ApiRouteV1.Banner_Add, Name = "AddBanner")]
        public async Task<ActionResult<ResponseResult>> AddBanner([FromBody] CreateBannerDTO bannerDTO)
            => await _mediator.Send(new CreateBannerRequest() { createBannerDTO = bannerDTO });

        [HttpPut(ApiRouteV1.Banner_ChangeStatus, Name = "ChangeBannerStatus")]
        public async Task<ActionResult<ResponseResult>> ChangeBannerStatus([FromBody] long Id)
            => await _mediator.Send(new ChangeBannerSelectedStatusRequest() { Id = Id });

        [HttpPut(ApiRouteV1.Banner_Delete, Name = "DeleteBanner")]
        public async Task<ActionResult<ResponseResult>> DeleteBanner([FromBody] long Id)
            => await _mediator.Send(new DeleteBannerRequest() { Id = Id });
    }
}

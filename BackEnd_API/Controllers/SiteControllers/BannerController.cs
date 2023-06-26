using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.GeneralInformations.BannerFeatures.Request.Queries;
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
        public async Task<ActionResult<ResponseResult>> GetAll()
            => await _mediator.Send(new GetBannerListRequest() { justShowSelected = true });

    }
}

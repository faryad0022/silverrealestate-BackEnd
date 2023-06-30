using Application.Const.Response;
using Application.features.GeneralInformations.SocialFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{
    public class SocialController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public SocialController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.Social_GetAll, Name = "GetSocialListAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetSocialListAsync()
             => await _mediator.Send(new GetSocialListRequest() { justShowSelected = true });

    }
}

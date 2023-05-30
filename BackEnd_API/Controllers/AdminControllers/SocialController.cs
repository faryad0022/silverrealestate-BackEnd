using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.GeneralInformations.SocialFeatures.Request.Commands;
using Application.features.GeneralInformations.SocialFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class SocialController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public SocialController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.Social_GetAll)]
        public async Task<ActionResult<ReturnData<SocialDTO>>> GetSocialListAsync()
            => await _mediator.Send(new GetSocialListRequest());


        [HttpGet(ApiRouteV1.Social_Get)]
        public async Task<ActionResult<ReturnData<SocialDTO>>> GetSocialAsync([FromQuery] long Id)
            => await _mediator.Send(new GetSocialRequest { Id = Id });


        [HttpPost(ApiRouteV1.Social_Add)]
        public async Task<ActionResult<ReturnData<CreateSocialDTO>>> AddSocialAsync([FromBody] CreateSocialDTO createSocialDTO)
            => await _mediator.Send(new CreateSocialRequest { createSocialDTO = createSocialDTO });

        [HttpPut(ApiRouteV1.Social_Update)]
        public async Task<ActionResult<ReturnData<UpdateSocialDTO>>> UpdateSocialAsync([FromQuery] UpdateSocialDTO updateSocialDTO)
            => await _mediator.Send(new UpdateSocialRequest { UpdateSocialDTO = updateSocialDTO });
    }
}

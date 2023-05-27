using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.GeneralInformations.SocialFeatures.Request.Commands;
using Application.features.GeneralInformations.SocialFeatures.Request.Queries;
using Application.Reaspose;
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
        [HttpGet("get-social-list")]
        public async Task<ActionResult<ReturnData<SocialDTO>>> GetSocialListAsync()
            => await _mediator.Send(new GetSocialListRequest());


        [HttpGet("get-social")]
        public async Task<ActionResult<ReturnData<SocialDTO>>> GetSocialAsync([FromQuery] long Id)
            => await _mediator.Send(new GetSocialRequest { Id = Id });


        [HttpPost("add-social")]
        public async Task<ActionResult<ReturnData<CreateSocialDTO>>> AddSocialAsync([FromBody] CreateSocialDTO createSocialDTO)
            => await _mediator.Send(new CreateSocialRequest { createSocialDTO = createSocialDTO });

        [HttpPut("update-social")]
        public async Task<ActionResult<ReturnData<UpdateSocialDTO>>> UpdateSocialAsync([FromQuery] UpdateSocialDTO updateSocialDTO)
            => await _mediator.Send(new UpdateSocialRequest { UpdateSocialDTO = updateSocialDTO });
    }
}

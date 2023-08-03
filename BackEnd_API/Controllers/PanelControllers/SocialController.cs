using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.GeneralInformations.SocialFeatures.Request.Commands;
using Application.features.GeneralInformations.SocialFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{

    public class SocialController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public SocialController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.Social_GetAll, Name = "GetSocialList")]
        public async Task<ActionResult<ResponseResultDTO>> GetSocialListAsync()
            => await _mediator.Send(new GetSocialListRequest());


        [HttpGet(ApiRouteV1.Social_Get, Name = "GetSocialAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetSocialAsync([FromBody] long Id)
            => await _mediator.Send(new GetSocialRequest { Id = Id });


        [HttpPost(ApiRouteV1.Social_Add, Name = "AddSocialAsync")]
        public async Task<ActionResult<ResponseResultDTO>> AddSocialAsync([FromBody] CreateSocialDTO createSocialDTO)
            => await _mediator.Send(new CreateSocialRequest { createSocialDTO = createSocialDTO });

        [HttpPut(ApiRouteV1.Social_Update, Name = "UpdateSocialAsync")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateSocialAsync([FromBody] UpdateSocialDTO updateSocialDTO)
            => await _mediator.Send(new UpdateSocialRequest { UpdateSocialDTO = updateSocialDTO });

        [HttpPut(ApiRouteV1.Social_Delete, Name = "DeleteSocialAsync")]
        public async Task<ActionResult<ResponseResultDTO>> DeleteSocialAsync([FromBody] long Id)
            => await _mediator.Send(new DeleteSocialRequest { Id = Id });
    }
}

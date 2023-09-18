using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.features.PanelAndSiteFeatures.GeneralInformations.CommonQuestionFeatures.Request.Command;
using Application.features.PanelAndSiteFeatures.GeneralInformations.CommonQuestionFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    [Authorize]

    public class CommonQuestionController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public CommonQuestionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.CommonQuestiom_GetAll, Name = "GetAllCommonQuestion")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllCommonQuestion()
            => await _mediator.Send(new GetCommonQuestionListRequest());

        [HttpGet(ApiRouteV1.CommonQuestiom_Get, Name = "GetCommonQuestion")]
        public async Task<ActionResult<ResponseResultDTO>> GetCommonQuestion([FromQuery] long Id)
            => await _mediator.Send(new GetCommonQuestionRequest() { Id = Id });

        [HttpPost(ApiRouteV1.CommonQuestiom_Add, Name = "AddCommonQuestion")]
        public async Task<ActionResult<ResponseResultDTO>> AddCommonQuestion([FromBody] CreateCommonQuestionDTO commonquestionDTO)
            => await _mediator.Send(new CreateCommonQuestionRequest() { createCommonQuestionDTO = commonquestionDTO });

        [HttpPut(ApiRouteV1.CommonQuestiom_Update, Name = "UpdateCommonQuestion")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateCommonQuestion([FromBody] UpdateCommonQuestionDTO commonquestionDTO)
            => await _mediator.Send(new UpdateCommonQuestionRequest() { updateCommonQuestionDTO = commonquestionDTO });

        [HttpPut(ApiRouteV1.CommonQuestiom_ChangeStatus, Name = "ChangeCommonQuestionStatus")]
        public async Task<ActionResult<ResponseResultDTO>> ChangeCommonQuestionStatus([FromBody] long Id)
            => await _mediator.Send(new ChangeCommonQuestionSelectedStatusRequest() { Id = Id });

        [HttpPut(ApiRouteV1.CommonQuestiom_Delete, Name = "DeleteCommonQuestion")]
        public async Task<ActionResult<ResponseResultDTO>> DeleteCommonQuestion([FromBody] long Id)
            => await _mediator.Send(new DeleteCommonQuestionRequest() { Id = Id });
    }
}

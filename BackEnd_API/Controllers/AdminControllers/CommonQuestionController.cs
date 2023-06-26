using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class CommonQuestionController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public CommonQuestionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.CommonQuestiom_GetAll,Name = "GetAllCommonQuestion")]
        public async Task<ActionResult<ResponseResult>> GetAllCommonQuestion()
            => await _mediator.Send(new GetCommonQuestionListRequest());

        [HttpGet(ApiRouteV1.CommonQuestiom_Get, Name = "GetCommonQuestion")]
        public async Task<ActionResult<ResponseResult>> GetCommonQuestion([FromQuery] long Id)
            => await _mediator.Send(new GetCommonQuestionRequest() { Id = Id });

        [HttpPost(ApiRouteV1.CommonQuestiom_Add, Name = "AddCommonQuestion")]
        public async Task<ActionResult<ResponseResult>> AddCommonQuestion([FromBody] CreateCommonQuestionDTO commonquestionDTO)
            => await _mediator.Send(new CreateCommonQuestionRequest() { createCommonQuestionDTO = commonquestionDTO });

        [HttpPut(ApiRouteV1.CommonQuestiom_Update, Name = "UpdateCommonQuestion")]
        public async Task<ActionResult<ResponseResult>> UpdateCommonQuestion([FromQuery] UpdateCommonQuestionDTO commonquestionDTO)
            => await _mediator.Send(new UpdateCommonQuestionRequest() { updateCommonQuestionDTO = commonquestionDTO });

        [HttpPut(ApiRouteV1.CommonQuestiom_ChangeStatus, Name = "ChangeCommonQuestionStatus")]
        public async Task<ActionResult<ResponseResult>> ChangeCommonQuestionStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeCommonQuestionSelectedStatusRequest() { Id = Id });
    }
}

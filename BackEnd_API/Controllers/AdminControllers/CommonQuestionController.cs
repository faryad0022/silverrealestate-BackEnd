using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries;
using Application.Reaspose;
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
        [HttpGet(ApiRouteV1.CommonQuestiom_GetAll)]
        public async Task<ActionResult<ReturnData<CommonQuestionDTO>>> GetAllCommonQuestion()
            => await _mediator.Send(new GetCommonQuestionListRequest());

        [HttpGet(ApiRouteV1.CommonQuestiom_Get)]
        public async Task<ActionResult<ReturnData<CommonQuestionDTO>>> GetCommonQuestion([FromQuery] long Id)
            => await _mediator.Send(new GetCommonQuestionRequest() { Id = Id });

        [HttpPost(ApiRouteV1.CommonQuestiom_Add)]
        public async Task<ActionResult<ReturnData<CreateCommonQuestionDTO>>> AddCommonQuestion([FromBody] CreateCommonQuestionDTO commonquestionDTO)
            => await _mediator.Send(new CreateCommonQuestionRequest() { createCommonQuestionDTO = commonquestionDTO });

        [HttpPut(ApiRouteV1.CommonQuestiom_Update)]
        public async Task<ActionResult<ReturnData<UpdateCommonQuestionDTO>>> UpdateCommonQuestion([FromQuery] UpdateCommonQuestionDTO commonquestionDTO)
            => await _mediator.Send(new UpdateCommonQuestionRequest() { updateCommonQuestionDTO = commonquestionDTO });

        [HttpPut(ApiRouteV1.CommonQuestiom_ChangeStatus)]
        public async Task<ActionResult<ReturnData<CommonQuestionDTO>>> ChangeCommonQuestionStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeCommonQuestionSelectedStatusRequest() { Id = Id });
    }
}

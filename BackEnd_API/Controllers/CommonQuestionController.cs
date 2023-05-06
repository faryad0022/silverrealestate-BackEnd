using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers
{

    public class CommonQuestionController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public CommonQuestionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("get-all-commonquestion")]
        public async Task<ActionResult<ReturnData<CommonQuestionDTO>>> GetAllCommonQuestion()
            => await _mediator.Send(new GetCommonQuestionListRequest());

        [HttpGet("get-commonquestion")]
        public async Task<ActionResult<ReturnData<CommonQuestionDTO>>> GetCommonQuestion([FromQuery] long Id)
            => await _mediator.Send(new GetCommonQuestionRequest() { Id = Id });

        [HttpPost("add-commonquestion")]
        public async Task<ActionResult<ReturnData<CreateCommonQuestionDTO>>> AddCommonQuestion([FromBody] CreateCommonQuestionDTO commonquestionDTO)
            => await _mediator.Send(new CreateCommonQuestionRequest() { createCommonQuestionDTO = commonquestionDTO });

        [HttpPut("update-commonquestion")]
        public async Task<ActionResult<ReturnData<UpdateCommonQuestionDTO>>> UpdateCommonQuestion([FromQuery] UpdateCommonQuestionDTO commonquestionDTO)
            => await _mediator.Send(new UpdateCommonQuestionRequest() { updateCommonQuestionDTO = commonquestionDTO });

        [HttpPut("change-commonquestion-status")]
        public async Task<ActionResult<ReturnData<CommonQuestionDTO>>> ChangeCommonQuestionStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeCommonQuestionSelectedStatusRequest() { Id = Id });
    }
}

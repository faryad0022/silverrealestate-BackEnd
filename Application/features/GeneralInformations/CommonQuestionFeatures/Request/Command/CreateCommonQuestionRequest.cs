using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command
{
    public class CreateCommonQuestionRequest : IRequest<ResponseResult>
    {
        public CreateCommonQuestionDTO createCommonQuestionDTO { get; set; }
    }
}

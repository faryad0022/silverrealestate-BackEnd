using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command
{
    public class UpdateCommonQuestionRequest : IRequest<ResponseResult>
    {
        public UpdateCommonQuestionDTO updateCommonQuestionDTO { get; set; }
    }
}

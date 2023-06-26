using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries
{
    public class GetCommonQuestionListRequest : IRequest<ResponseResult>
    {
        public bool justShowSelected { get; set; } = false;
    }
}

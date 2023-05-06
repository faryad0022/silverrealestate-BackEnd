using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries
{
    public class GetCommonQuestionListRequest : IRequest<ReturnData<CommonQuestionDTO>>
    {
        public bool justShowSelected { get; set; } = false;
    }
}

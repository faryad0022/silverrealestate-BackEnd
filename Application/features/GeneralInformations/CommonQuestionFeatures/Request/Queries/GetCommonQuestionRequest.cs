using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries
{
    public class GetCommonQuestionRequest : IRequest<ReturnData<CommonQuestionDTO>>
    {
        public long Id { get; set; }
    }
}

using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command
{
    public class UpdateCommonQuestionRequest : IRequest<ReturnData<UpdateCommonQuestionDTO>>
    {
        public UpdateCommonQuestionDTO updateCommonQuestionDTO { get; set; }
    }
}

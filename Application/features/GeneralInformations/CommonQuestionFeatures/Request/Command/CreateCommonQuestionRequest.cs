using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command
{
    public class CreateCommonQuestionRequest : IRequest<ReturnData<CreateCommonQuestionDTO>>
    {
        public CreateCommonQuestionDTO createCommonQuestionDTO { get; set; }
    }
}

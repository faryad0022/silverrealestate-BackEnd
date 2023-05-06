using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command
{
    public class ChangeCommonQuestionSelectedStatusRequest : IRequest<ReturnData<CommonQuestionDTO>>
    {
        public long Id { get; set; }
    }
}

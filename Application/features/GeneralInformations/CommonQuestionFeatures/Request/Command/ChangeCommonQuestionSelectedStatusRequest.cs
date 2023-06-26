using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command
{
    public class ChangeCommonQuestionSelectedStatusRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}

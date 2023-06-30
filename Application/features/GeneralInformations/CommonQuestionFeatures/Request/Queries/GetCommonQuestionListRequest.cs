using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries
{
    public class GetCommonQuestionListRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; } = false;
    }
}

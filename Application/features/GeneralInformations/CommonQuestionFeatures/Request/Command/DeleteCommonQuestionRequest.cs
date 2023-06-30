using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command
{
    public class DeleteCommonQuestionRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}

using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.ConstructorInformations.Request.Queries
{
    public class GetConstructorInformationListRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; } = false;
    }
}

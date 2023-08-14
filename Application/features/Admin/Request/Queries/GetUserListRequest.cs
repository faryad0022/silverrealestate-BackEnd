using Application.Const.Response;
using MediatR;

namespace Application.features.Admin.Request.Queries
{
    public class GetUserListRequest : IRequest<ResponseResultDTO>
    {
    }
}

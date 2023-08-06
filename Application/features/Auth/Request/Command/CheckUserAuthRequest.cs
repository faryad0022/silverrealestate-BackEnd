using Application.Const.Response;
using MediatR;

namespace Application.features.Auth.Request.Command
{
    public class CheckUserAuthRequest : IRequest<ResponseResultDTO>
    {
    }
}

using Application.Const.Response;
using MediatR;

namespace Application.features.Admin.Request.Commands
{
    public class ChangeUserActivationRequest : IRequest<ResponseResultDTO>
    {
        public string userId { get; set; }
    }
}

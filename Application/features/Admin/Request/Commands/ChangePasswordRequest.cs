using Application.Const.Response;
using MediatR;

namespace Application.features.Admin.Request.Commands
{
    public class ChangePasswordRequest : IRequest<ResponseResultDTO>
    {
        public string userId { get; set; }
        public string newPassword { get; set; }
    }
}

using Application.Const.Response;
using MediatR;

namespace Application.features.Admin.Request.Commands
{
    public class UpdateUserRoleRequest : IRequest<ResponseResultDTO>
    {
        public string userId { get; set; }
        public string roleName { get; set; }
    }
}

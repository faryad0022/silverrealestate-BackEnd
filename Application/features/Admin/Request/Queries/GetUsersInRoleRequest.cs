using Application.Const.Response;
using MediatR;

namespace Application.features.Admin.Request.Queries
{
    public class GetUsersInRoleRequest : IRequest<ResponseResultDTO>
    {
        public string roleName { get; set; }
    }
}

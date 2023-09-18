using Application.Const.Response;
using MediatR;

namespace Application.features.Admin.Request.Queries
{
    public class GetUserRolesRequest : IRequest<ResponseResultDTO>
    {
        public string userId { get; set; }
    }
}

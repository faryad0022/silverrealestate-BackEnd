using Application.Const.Response;
using Application.Models.Identity;
using MediatR;

namespace Application.features.Admin.Request.Commands
{
    public class AddNewUserRequest : IRequest<ResponseResultDTO>
    {
        public RegisterRequestDTO request { get; set; }
    }
}

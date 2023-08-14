using Application.Const.Response;
using Application.Models.Identity;
using MediatR;

namespace Application.features.Auth.Request.Command
{
    public class SignInRequest : IRequest<ResponseResultDTO>
    {
        public AuthRequestDTO authRequest { get; set; }
    }
}

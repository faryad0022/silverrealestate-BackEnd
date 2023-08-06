using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Auth.Request.Command;
using Application.Models.Identity;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Auth.Handler.Command
{
    public class CheckUserAuthRequestHandler : IRequestHandler<CheckUserAuthRequest, ResponseResultDTO>
    {
        private readonly IAuthService _authService;

        public CheckUserAuthRequestHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<ResponseResultDTO> Handle(CheckUserAuthRequest request, CancellationToken cancellationToken)
        {
            var res = await _authService.Authenticated();
            if (res.AuthResponseResult == AuthResponseResult.NotLoggedIn)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotLoggedIn, null);
            return ResponseResultDTO.SetResult(res, StatusMessage.Success, null);
        }
    }
}

using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Auth.Request.Command;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Auth.Handler.Command
{
    public class SignInRequestHandler : IRequestHandler<SignInRequest, ResponseResultDTO>
    {
        private readonly IAuthService _authService;

        public SignInRequestHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<ResponseResultDTO> Handle(SignInRequest request, CancellationToken cancellationToken)
        {
            var res = await _authService.Login(request.authRequest);
            switch (res.AuthResponseResult)
            {
                case Models.Identity.AuthResponseResult.InvalidInputs:
                    return ResponseResultDTO.SetResult(res, StatusMessage.InvalidInputs, null);
                case Models.Identity.AuthResponseResult.NotActive:
                    return ResponseResultDTO.SetResult(res, StatusMessage.NotActive, null);
                case Models.Identity.AuthResponseResult.UserNotFound:
                    return ResponseResultDTO.SetResult(res, StatusMessage.NotFound, null);
                default:
                    break;
            }
            return ResponseResultDTO.SetResult(res, StatusMessage.Success, null);
        }
    }
}

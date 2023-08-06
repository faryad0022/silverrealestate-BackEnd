using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Auth.Request.Command;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Auth.Handler.Command
{
    public class RegisterationRequestHandler : IRequestHandler<RegisterationRequest, ResponseResultDTO>
    {
        private readonly IAuthService _authService;

        public RegisterationRequestHandler(IAuthService authService)
        {
            _authService = authService;
        }
        public async Task<ResponseResultDTO> Handle(RegisterationRequest request, CancellationToken cancellationToken)
        {
            var res = await _authService.Register(request.registerRequest);
            switch (res.RegisterResponseResult)
            {
                case Models.Identity.RegisterResponseResult.EmailExist:
                    return ResponseResultDTO.SetResult(res, StatusMessage.EmailExist, null);
                case Models.Identity.RegisterResponseResult.UserExist:
                    return ResponseResultDTO.SetResult(res, StatusMessage.UserExist, null);
                default:
                    break;
            }
            return ResponseResultDTO.SetResult(res, StatusMessage.Success, null);
        }
    }
}

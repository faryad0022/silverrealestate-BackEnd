using Application.Const.Response;
using Application.Contract.Identity;
using Application.features.Admin.Request.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Admin.Handler.Commands
{
    public class AddNewUserRequestHandler : IRequestHandler<AddNewUserRequest, ResponseResultDTO>
    {
        private readonly IUserService _userService;

        public AddNewUserRequestHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseResultDTO> Handle(AddNewUserRequest request, CancellationToken cancellationToken)
        {
            var newUser = await _userService.AddNewUserAsync(request.request);
            if (newUser == null)
                return ResponseResultDTO.SetResult(null, StatusMessage.UserExist, null);
            return ResponseResultDTO.SetResult(newUser, StatusMessage.Success, null);
        }
    }
}

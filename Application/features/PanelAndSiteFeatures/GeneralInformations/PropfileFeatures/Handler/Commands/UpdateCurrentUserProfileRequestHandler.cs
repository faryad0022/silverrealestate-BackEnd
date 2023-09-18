using Application.Const.PathUtility;
using Application.Const.Response;
using Application.Contract.Identity;
using Application.Extensions;
using Application.features.PanelAndSiteFeatures.GeneralInformations.PropfileFeatures.Request.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.PropfileFeatures.Handler.Commands
{
    public class UpdateCurrentUserProfileRequestHandler : IRequestHandler<UpdateCurrentUserProfileRequest, ResponseResultDTO>
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public UpdateCurrentUserProfileRequestHandler(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        public async Task<ResponseResultDTO> Handle(UpdateCurrentUserProfileRequest request, CancellationToken cancellationToken)
        {
            var currentUser = await _userService.GetUserByIdAsync(_authService.GetUserId());
            #region Upload Image
            if (request.currentUser.ImageName != "")
            {
                var createdImageName = ImageUploaderExtensions.UploadImage(request.currentUser.ImageName, PathTools.ProfileServerPath, currentUser.ImageName);
                if (string.IsNullOrEmpty(createdImageName))
                    return ResponseResultDTO.SetResult(null, StatusMessage.UploadError, null);
                request.currentUser.ImageName = createdImageName;
            }
            else
            {
                request.currentUser.ImageName = currentUser.ImageName;
            }

            #endregion
            currentUser.PhoneNumber = request.currentUser.PhoneNumber;
            currentUser.FirstName = request.currentUser.FirstName;
            currentUser.LastName = request.currentUser.LastName;
            currentUser.ImageName = request.currentUser.ImageName;
            var result = await _userService.UpdateCurrentUserAsync(currentUser);
            if (result is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.Error, null);
            return ResponseResultDTO.SetResult(currentUser, StatusMessage.Success, null);

        }
    }
}

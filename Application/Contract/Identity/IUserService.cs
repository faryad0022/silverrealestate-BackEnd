using Application.Models.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Identity
{
    public interface IUserService
    {
        Task<CurrentUserDTO> GetUserByIdAsync(string userId);
        Task<List<UserRoleDTO>> GetUserRolesAsync(string userId);
        Task<List<RegisteredUserDTO>> GetRegisteredUserListAsync();
        Task<List<RegisteredUserDTO>> GetRegisteredUserListInRoleAsync(string roleName);
        Task<RegisteredUserDTO> ChangeUserActivation(string userId);
        Task<CurrentUserDTO> UpdateCurrentUserAsync(CurrentUserDTO currentUser);
        Task<RegisteredUserDTO> UpdateUserRoleAsync(string userId,string roleName);
        Task<RegisteredUserDTO> AddNewUserAsync(RegisterRequestDTO registerRequest);
        Task<RegisteredUserDTO> SetNewPassword(string userId, string password);
        Task<List<RoleDTO>> GetRolesAsync();

    }
}

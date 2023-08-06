using Application.Models.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Identity
{
    public interface IUserService
    {
        Task<CurrentUser> GetCurrentUserByIdAsync(string userId);
        Task<List<RegisteredUser>> GetRegisteredUserListAsync();
        Task<List<RegisteredUser>> GetRegisteredUserListInRoleAsync(string roleName);
        Task<CurrentUser> ChangeUserActivation(string userId);
        Task<CurrentUser> UpdateCurrentUserAsync(CurrentUser currentUser);
        Task<CurrentUser> AddUserToRoleAsync(string userId,string roleName);

    }
}

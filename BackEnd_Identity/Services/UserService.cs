using Application.Contract.Identity;
using Application.Models.Identity;
using BackEnd_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;

namespace BackEnd_Identity.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAuthService _authService;

        public UserService(UserManager<ApplicationUser> userManager, IAuthService authService)
        {
            _userManager = userManager;
            _authService = authService;
        }

        public async Task<CurrentUser> AddUserToRoleAsync(string userId,string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.AddToRoleAsync(user, roleName);
            return new CurrentUser()
            {
                Email = user.Email,
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                ImageName = user.ImageName
            };
        }

        public async Task<CurrentUser> ChangeUserActivation(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            user.EmailConfirmed = !user.EmailConfirmed;
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return new CurrentUser()
                {
                    Email = user.Email,
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    ImageName = user.ImageName
                };
            }
            return null;
        }

        public async Task<CurrentUser> GetCurrentUserByIdAsync(string userId)
        {
            var currentUser = await _userManager.FindByIdAsync(userId);
            return new CurrentUser()
            {
                Email = currentUser.Email,
                Id = currentUser.Id,
                UserName = currentUser.UserName,
                FirstName = currentUser.FirstName,
                LastName = currentUser.LastName,
                PhoneNumber = currentUser.PhoneNumber,
                ImageName = currentUser.ImageName
            };
        }

        public async Task<List<RegisteredUser>> GetRegisteredUserListAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            return users.Select(q => new RegisteredUser
            {
                Id = q.Id,
                Email = q.Email,
                FirstName = q.FirstName,
                LastName = q.LastName,
                UserName = q.UserName,
                PhoneNumber = q.PhoneNumber,
                ImageName = q.ImageName
            }).ToList();
        }

        public async Task<List<RegisteredUser>> GetRegisteredUserListInRoleAsync(string roleName)
        {
            var users = await _userManager.GetUsersInRoleAsync(roleName);
            return users.Select(q => new RegisteredUser
            {
                Id = q.Id,
                Email = q.Email,
                FirstName = q.FirstName,
                LastName = q.LastName,
                UserName = q.UserName,
                PhoneNumber = q.PhoneNumber,
                ImageName = q.ImageName
            }).ToList();
        }
        public async Task<CurrentUser> UpdateCurrentUserAsync(CurrentUser currentUser)
        {
            var user = await _userManager.FindByIdAsync(currentUser.Id);
            user.PhoneNumber = currentUser.PhoneNumber;
            user.FirstName = currentUser.FirstName;
            user.LastName = currentUser.LastName;
            user.ImageName = currentUser.ImageName;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return new CurrentUser()
                {
                    Email = user.Email,
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    ImageName = user.ImageName
                };
            }
            return null;

        }

    }
}

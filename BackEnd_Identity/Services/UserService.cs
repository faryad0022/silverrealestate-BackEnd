using Application.Contract.Identity;
using Application.Models.Identity;
using AutoMapper;
using BackEnd_Identity.Extentions;
using BackEnd_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Identity.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly IdentityDbContext _dbContext;
        private readonly IAuthService _authService;


        public UserService(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IMapper mapper,
            IdentityDbContext dbContext,
            IAuthService authService

            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _dbContext = dbContext;
            _authService = authService;
        }
        public async Task<RegisteredUserDTO> UpdateUserRoleAsync(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var res = await _userManager.IsInRoleAsync(user, roleName);
            if (res)
            {
                await _userManager.RemoveFromRoleAsync(user, roleName);
                return _mapper.Map<RegisteredUserDTO>(user);
            }

            var res1 = await _userManager.AddToRoleAsync(user, roleName);
            return _mapper.Map<RegisteredUserDTO>(user);

        }
        public async Task<RegisteredUserDTO> ChangeUserActivation(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            user.EmailConfirmed = !user.EmailConfirmed;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return _mapper.Map<RegisteredUserDTO>(user);
            }
            return null;
        }
        public async Task<CurrentUserDTO> GetUserByIdAsync(string userId)
        {
            var currentUser = await _userManager.FindByIdAsync(userId);
            return _mapper.Map<CurrentUserDTO>(currentUser);
        }
        public async Task<List<RegisteredUserDTO>> GetRegisteredUserListAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            return _mapper.Map<List<RegisteredUserDTO>>(users);
        }
        public async Task<List<RegisteredUserDTO>> GetRegisteredUserListInRoleAsync(string roleName)
        {
            var users = await _userManager.GetUsersInRoleAsync(roleName);
            return _mapper.Map<List<RegisteredUserDTO>>(users);
        }
        public async Task<CurrentUserDTO> UpdateCurrentUserAsync(CurrentUserDTO currentUser)
        {
            var user = await _userManager.FindByIdAsync(currentUser.Id);
            user.PhoneNumber = currentUser.PhoneNumber;
            user.FirstName = currentUser.FirstName;
            user.LastName = currentUser.LastName;
            user.ImageName = currentUser.ImageName;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return _mapper.Map<CurrentUserDTO>(user);
            }
            return null;

        }
        public async Task<List<UserRoleDTO>> GetUserRolesAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var applicationUserRole = await _dbContext.ApplicationUserRoles
                .Include(x => x.User)
                .Include(x => x.Role)
                .Where(x => x.UserId == userId).ToListAsync();
            var userRole = _mapper.Map<List<UserRoleDTO>>(applicationUserRole);
            return userRole;

        }
        public async Task<RegisteredUserDTO> AddNewUserAsync(RegisterRequestDTO registerRequest)
        {
            var existingUser = await _userManager.FindByEmailAsync(registerRequest.UserName);

            if (existingUser != null)
            {
                return new RegisteredUserDTO
                {
                    Id = "",
                };
            }

            var user = new ApplicationUser
            {
                Email = registerRequest.Email.SanitizeText(),
                UserName = registerRequest.UserName.SanitizeText(),
                ImageName = "blank.png",
                EmailConfirmed = true
            };

            var existingEmail = await _userManager.FindByEmailAsync(registerRequest.Email);

            if (existingEmail == null)
            {
                var result = await _userManager.CreateAsync(user, registerRequest.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Employee");
                    return new RegisteredUserDTO
                    {
                        Id = user.Id,
                        Email = user.Email,
                        UserName = user.UserName,
                        EmailConfirmed = user.EmailConfirmed,
                        ImageName = user.ImageName,

                    };
                }
                else
                {
                    throw new Exception($"{result.Errors}");
                }
            }
            else
            {
                return new RegisteredUserDTO
                {
                    Id = "",
                };
            }
        }
        public async Task<RegisteredUserDTO> SetNewPassword(string userId, string password)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded)
                return _mapper.Map<RegisteredUserDTO>(user);
            throw new Exception($"{result.Errors}");
        }
        public async Task<List<RoleDTO>> GetRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return _mapper.Map<List<RoleDTO>>(roles);
        }
    }
}

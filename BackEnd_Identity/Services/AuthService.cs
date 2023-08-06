using Application.Const.Auth;
using Application.Contract.Identity;
using Application.Models.Identity;
using BackEnd_Identity.Extentions;
using BackEnd_Identity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Identity.Services
{
    public class AuthService : IAuthService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JWTSettings _jwtSettings;

        public AuthService(
            IHttpContextAccessor httpContextAccessor,
            UserManager<ApplicationUser> userManager,
            IOptions<JWTSettings> jwtSettings,
            SignInManager<ApplicationUser> signInManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
            _signInManager = signInManager;
        }

        public async Task<AuthResponse> Authenticated()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                var userId = GetUserId(_httpContextAccessor.HttpContext.User);
                var user = await _userManager.FindByIdAsync(userId);
                var token = await GenerateToken(user);
                return new AuthResponse
                {
                    Email = user.Email,
                    Id = userId,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    UserName = user.UserName,
                    AuthResponseResult = AuthResponseResult.Success
                };
            }
            return new AuthResponse
            {
                Email = null,
                Id = null,
                Token = null,
                UserName = null,
                AuthResponseResult = AuthResponseResult.NotLoggedIn
            }; ;
        }

        public string GetUserId()
        {

            return GetUserId(_httpContextAccessor.HttpContext.User);

        }

        public async Task<AuthResponse> Login(AuthRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                return new AuthResponse
                {
                    AuthResponseResult = AuthResponseResult.UserNotFound
                };
            }


            var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);

            if (!result.Succeeded)
            {
                return new AuthResponse
                {
                    AuthResponseResult = AuthResponseResult.InvalidInputs
                };
            }

            JwtSecurityToken jwtSecurityToken = await GenerateToken(user);

            AuthResponse response = new()
            {
                Id = user.Id,
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                Email = user.Email.SanitizeText(),
                UserName = user.UserName.SanitizeText(),
                AuthResponseResult = AuthResponseResult.Success
            };

            return response;
        }

        public async Task<RegisterResponse> Register(RegisterRequest request)
        {
            var existingUser = await _userManager.FindByEmailAsync(request.UserName);

            if (existingUser != null)
            {
                return new RegisterResponse
                {
                    UserId = "",
                    RegisterResponseResult = RegisterResponseResult.UserExist
                };
            }

            var user = new ApplicationUser
            {
                Email = request.Email.SanitizeText(),
                UserName = request.UserName.SanitizeText(),
                ImageName = "blank.png",
                EmailConfirmed = true
            };

            var existingEmail = await _userManager.FindByEmailAsync(request.Email);

            if (existingEmail == null)
            {
                var result = await _userManager.CreateAsync(user, request.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Employee");
                    return new RegisterResponse
                    {
                        UserId = user.Id,
                        RegisterResponseResult = RegisterResponseResult.Success
                    };
                }
                else
                {
                    throw new Exception($"{result.Errors}");
                }
            }
            else
            {
                return new RegisterResponse
                {
                    UserId = "",
                    RegisterResponseResult = RegisterResponseResult.EmailExist
                };
            }
        }


        private async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, roles[i]));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(CustomClaimTypes.UserId,user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }

        private string GetUserId(ClaimsPrincipal claimsPrincipal)
        {
            if (claimsPrincipal != null)
            {
                var result = claimsPrincipal.FindFirst(CustomClaimTypes.UserId).Value;
                return result;
            }
            return default;
        }
    }
}

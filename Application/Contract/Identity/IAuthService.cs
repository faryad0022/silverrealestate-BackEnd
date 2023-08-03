using Application.Models.Identity;
using System.Threading.Tasks;

namespace Application.Contract.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest authRequest);
        Task<RegisterResponse> Register(RegisterRequest registerRequest);
    }
}

using Application.Models.Identity;
using System.Threading.Tasks;

namespace Application.Contract.Identity
{
    public interface IAuthService
    {
        Task<CurrentUserDTO> Login(AuthRequestDTO authRequest);
        Task<RegisterResponseDTO> Register(RegisterRequestDTO registerRequest);
        Task<CurrentUserDTO> Authenticated();
        string GetUserId();

    }
}

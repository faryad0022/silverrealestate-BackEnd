using Application.Models;
using System.Threading.Tasks;

namespace Application.Contract.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmailAsync(Email email);
    }
}

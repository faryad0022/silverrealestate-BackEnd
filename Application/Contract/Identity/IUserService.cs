using Application.Models.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Identity
{
    public interface IUserService
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployee(string userId);
    }
}

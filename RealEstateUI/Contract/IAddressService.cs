using RealEstateUI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateUI.Contract
{
    public interface IAddressService
    {
        Task<AddressVM> GetEntityAsync(long Id);
        Task<IReadOnlyList<AddressVM>> GetAllAsync();
    }
}

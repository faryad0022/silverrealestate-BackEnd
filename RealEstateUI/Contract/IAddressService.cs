using RealEstateUI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateUI.Contract
{
    public interface IAddressService
    {
        Task<AddressVM> GetAddressEntityAsync(long Id);
        Task<IReadOnlyList<AddressVM>> GetAllAddressAsync();
    }
}

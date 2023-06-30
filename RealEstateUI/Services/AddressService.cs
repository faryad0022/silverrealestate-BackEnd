using AutoMapper;
using RealEstateUI.Contract;
using RealEstateUI.Models;
using RealEstateUI.Services.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateUI.Services
{
    public class AddressService : IAddressService
    {
        private readonly IClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly IMapper _mapper;

        public AddressService(IClient httpClient, ILocalStorageService localStorage, IMapper mapper)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _mapper = mapper;
        }



        public async Task<IReadOnlyList<AddressVM>> GetAllAddressAsync()
        {
            var addressList = await _httpClient.GetAllAddressAsync();
            return _mapper.Map<List<AddressVM>>(addressList.Tentities);
        }
        public async Task<AddressVM> GetAddressEntityAsync(long entityId)
        {
            var address = await _httpClient.GetAddressAsync();
            return _mapper.Map<AddressVM>(address.Tentity);
        }


    }
}

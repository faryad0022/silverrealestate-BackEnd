using AutoMapper;
using RealEstateUI.Contract;
using RealEstateUI.Models;
using RealEstateUI.Services.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateUI.Services
{
    public class ConstructorInformationService : IConstructorInformationService
    {
        private readonly IClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly IMapper _mapper;

        public ConstructorInformationService(IClient httpClient, ILocalStorageService localStorage, IMapper mapper)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _mapper = mapper;
        }


        public async Task<IReadOnlyList<ConstructorVM>> GetAllConstructorAsync()
        {
            var constructorList = await _httpClient.GetAllConstructorInformationAsync();
            return _mapper.Map<List<ConstructorVM>>(constructorList.Tentities);
        }
    }
}

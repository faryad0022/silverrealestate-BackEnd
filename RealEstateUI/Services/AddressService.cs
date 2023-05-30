﻿using AutoMapper;
using RealEstateUI.Contract;
using RealEstateUI.Models;
using RealEstateUI.Services.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateUI.Services
{
    public class AddressService : IAddressService
    {
        private readonly IClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly IMapper _mapper;

        public AddressService(IClient httpClient,ILocalStorageService localStorage,IMapper mapper)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _mapper = mapper;
        }
        public async Task<IReadOnlyList<AddressVM>> GetAllAsync()
        {
            var x = await _httpClient.GetallAsync();
            return _mapper.Map<List<AddressVM>>(x.Tentities);
        }
        public async Task<AddressVM> GetEntityAsync(long entityId)
        {
            var x = await _httpClient.GetAsync();
            return _mapper.Map<AddressVM>(x.Tentity);
        }
    }
}

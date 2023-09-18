﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.features.PanelAndSiteFeatures.GeneralInformations.AddressFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.AddressFeatures.Handler.Queries
{
    public class GetAddressListRequestHandler : IRequestHandler<GetAddressListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetAddressListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetAddressListRequest request, CancellationToken cancellationToken)
        {
            var addressList = await _unitofWork.AddressRepository.GetAllAsync();
            if (addressList is null || addressList.Count == 0)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedAddress = addressList.Where(x => x.IsSelected).ToList();
                var SelectedAddressDTo = _mapper.Map<List<AddressDTO>>(selectedAddress);
                return ResponseResultDTO.SetResult(SelectedAddressDTo, StatusMessage.Success, null);
            }
            var addressListDTO = _mapper.Map<List<AddressDTO>>(addressList);
            return ResponseResultDTO.SetResult(addressListDTO, StatusMessage.Success, null);

        }
    }
}
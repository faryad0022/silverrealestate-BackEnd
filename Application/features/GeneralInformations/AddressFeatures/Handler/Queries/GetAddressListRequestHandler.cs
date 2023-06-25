﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.features.GeneralInformations.AddressFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AddressFeatures.Handler.Queries
{
    public class GetAddressListRequestHandler : IRequestHandler<GetAddressListRequest, ReturnData<AddressDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetAddressListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<AddressDTO>> Handle(GetAddressListRequest request, CancellationToken cancellationToken)
        {
            var addressList = await _unitofWork.AddressRepository.GetAllAsync();
            if (addressList is null || addressList.Count == 0)
                return SetReturnData<AddressDTO>.SetTEntities(null, ResponseStatus.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedAddress = addressList.Where(x => x.IsSelected).ToList();
                var SelectedAddressDTo = _mapper.Map<List<AddressDTO>>(selectedAddress);
                return SetReturnData<AddressDTO>.SetTEntities(SelectedAddressDTo, ResponseStatus.Success, null);
            }
            var addressListDTO = _mapper.Map<List<AddressDTO>>(addressList);
            return SetReturnData<AddressDTO>.SetTEntities(addressListDTO, ResponseStatus.Success, null);

        }
    }
}

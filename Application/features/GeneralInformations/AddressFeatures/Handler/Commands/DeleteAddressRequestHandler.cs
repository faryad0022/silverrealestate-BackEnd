﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.features.GeneralInformations.AddressFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AddressFeatures.Handler.Commands
{
    public class DeleteAddressRequestHandler : IRequestHandler<DeleteAddressRequest, ReturnData<AddressDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteAddressRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<AddressDTO>> Handle(DeleteAddressRequest request, CancellationToken cancellationToken)
        {
            var address = await _unitofWork.AddressRepository.GetEntityAsync(request.Id);
            if (address is null)
                return SetReturnData<AddressDTO>.SetTEntity(
                    null,
                    ResponseStatus.NotFound,
                    null
                    );
            var addressDTO = _mapper.Map<AddressDTO>(address);
            _unitofWork.AddressRepository.DeleteEntityAsync(address);
            await _unitofWork.SaveChangesAsync();
            return SetReturnData<AddressDTO>.SetTEntity(
                addressDTO,
                ResponseStatus.Success,
                null
                );
        }
    }
}

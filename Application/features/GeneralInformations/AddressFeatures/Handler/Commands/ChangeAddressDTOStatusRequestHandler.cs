﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.features.GeneralInformations.AddressFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AddressFeatures.Handler.Commands
{
    public class ChangeAddressDTOStatusRequestHandler : IRequestHandler<ChangeAddressDTOStatusRequest, ReturnData<AddressDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeAddressDTOStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<AddressDTO>> Handle(ChangeAddressDTOStatusRequest request, CancellationToken cancellationToken)
        {
            var address = await _unitofWork.AddressRepository.GetEntityAsync(request.Id);
            if (address is null)
                return FillRetuenData<AddressDTO>.FillByEntity(null, ResponseStatus.NotFound, null);
            _unitofWork.AddressRepository.ChangeSelectedStatusAsync(address);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<AddressDTO>.FillByEntity(_mapper.Map<AddressDTO>(address), ResponseStatus.Success, null);
        }
    }
}

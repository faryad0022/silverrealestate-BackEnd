using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.features.GeneralInformations.AddressFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AddressFeatures.Handler.Commands
{
    public class DeleteAddressRequestHandler : IRequestHandler<DeleteAddressRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteAddressRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeleteAddressRequest request, CancellationToken cancellationToken)
        {
            var address = await _unitofWork.AddressRepository.GetEntityAsync(request.Id);
            if (address is null)
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.NotFound,
                    null
                    );
            var addressDTO = _mapper.Map<AddressDTO>(address);
            _unitofWork.AddressRepository.DeleteEntity(address);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(
                addressDTO,
                StatusMessage.Success,
                null
                );
        }
    }
}

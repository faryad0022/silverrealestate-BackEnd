using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.features.GeneralInformations.AddressFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AddressFeatures.Handler.Commands
{
    public class ChangeAddressDTOStatusRequestHandler : IRequestHandler<ChangeAddressDTOStatusRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeAddressDTOStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(ChangeAddressDTOStatusRequest request, CancellationToken cancellationToken)
        {
            var address = await _unitofWork.AddressRepository.GetEntityAsync(request.Id);
            if (address is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.AddressRepository.ChangeSelectedStatus(address);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<AddressDTO>(address), StatusMessage.Success, null);
        }
    }
}

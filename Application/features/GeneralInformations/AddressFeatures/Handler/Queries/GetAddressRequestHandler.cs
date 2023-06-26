using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.features.GeneralInformations.AddressFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AddressFeatures.Handler.Queries
{
    public class GetAddressRequestHandler : IRequestHandler<GetAddressRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetAddressRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(GetAddressRequest request, CancellationToken cancellationToken)
        {
            var address = await _unitofWork.AddressRepository.GetEntityAsync(request.Id);
            if (address is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            return ResponseResult.SetResult(_mapper.Map<AddressDTO>(address), StatusMessage.Success, null);
        }
    }
}

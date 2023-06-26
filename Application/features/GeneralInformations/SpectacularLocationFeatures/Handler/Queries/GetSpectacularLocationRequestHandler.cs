using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Handler.Queries
{
    public class GetSpectacularLocationRequestHandler : IRequestHandler<GetSpectacularLocationRequest, ResponseResult>
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public GetSpectacularLocationRequestHandler(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public async Task<ResponseResult> Handle(GetSpectacularLocationRequest request, CancellationToken cancellationToken)
        {
            var spectacularLocation = await _unitofWork.SpectacularlocationRepository.GetEntityAsync(request.Id);
            if (spectacularLocation is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            var spectacularLocationDTO = _mapper.Map<SpectacularLocationDTO>(spectacularLocation);
            return ResponseResult.SetResult(spectacularLocationDTO, StatusMessage.Success, null);
        }
    }
}

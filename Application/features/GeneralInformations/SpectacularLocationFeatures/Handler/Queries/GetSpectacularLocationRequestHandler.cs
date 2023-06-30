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
    public class GetSpectacularLocationRequestHandler : IRequestHandler<GetSpectacularLocationRequest, ResponseResultDTO>
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public GetSpectacularLocationRequestHandler(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public async Task<ResponseResultDTO> Handle(GetSpectacularLocationRequest request, CancellationToken cancellationToken)
        {
            var spectacularLocation = await _unitofWork.SpectacularlocationRepository.GetEntityAsync(request.Id);
            if (spectacularLocation is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var spectacularLocationDTO = _mapper.Map<SpectacularLocationDTO>(spectacularLocation);
            return ResponseResultDTO.SetResult(spectacularLocationDTO, StatusMessage.Success, null);
        }
    }
}

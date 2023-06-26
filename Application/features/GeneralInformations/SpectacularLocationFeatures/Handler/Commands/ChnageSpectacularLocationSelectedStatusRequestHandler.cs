using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Handler.Commands
{
    public class ChnageSpectacularLocationSelectedStatusRequestHandler : IRequestHandler<ChnageSpectacularLocationSelectedStatusRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChnageSpectacularLocationSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(ChnageSpectacularLocationSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var spectacularLocation = await _unitofWork.SpectacularlocationRepository.GetEntityAsync(request.Id);
            if (spectacularLocation is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.SpectacularlocationRepository.ChangeSelectedStatusAsync(spectacularLocation);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(
                _mapper.Map<SpectacularLocationDTO>(spectacularLocation),
                StatusMessage.Success,
                null
                );
        }
    }
}

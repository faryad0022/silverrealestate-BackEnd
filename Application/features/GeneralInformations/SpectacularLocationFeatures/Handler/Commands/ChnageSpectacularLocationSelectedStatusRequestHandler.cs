using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Handler.Commands
{
    public class ChnageSpectacularLocationSelectedStatusRequestHandler : IRequestHandler<ChnageSpectacularLocationSelectedStatusRequest, ReturnData<SpectacularLocationDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChnageSpectacularLocationSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<SpectacularLocationDTO>> Handle(ChnageSpectacularLocationSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var spectacularLocation = await _unitofWork.SpectacularlocationRepository.GetEntityAsync(request.Id);
            if (spectacularLocation is null)
                return SetReturnData<SpectacularLocationDTO>.SetTEntity(null, ResponseStatus.NotFound, null);
            _unitofWork.SpectacularlocationRepository.ChangeSelectedStatusAsync(spectacularLocation);
            await _unitofWork.SaveChangesAsync();
            return SetReturnData<SpectacularLocationDTO>.SetTEntity(
                _mapper.Map<SpectacularLocationDTO>(spectacularLocation),
                ResponseStatus.Success,
                null
                );
        }
    }
}

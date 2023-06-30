using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Handler.Commands
{
    public class ChangeSpectacularLocationImageSelectedStatusRequestHandler : IRequestHandler<ChangeSpectacularLocationImageSelectedStatusRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeSpectacularLocationImageSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(ChangeSpectacularLocationImageSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var spectacularLocationImage = await _unitofWork.SpectacularLocationImageRepository.GetEntityAsync(request.Id);
            if (spectacularLocationImage is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.SpectacularLocationImageRepository.ChangeSelectedStatus(spectacularLocationImage);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(
                _mapper.Map<SpectacularLocationImagesDTO>(spectacularLocationImage),
                StatusMessage.Success,
                null
                );
        }
    }
}

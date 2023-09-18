using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationImageFeatures.Handler.Queries
{
    public class GetSpectacularLocationImagesWithDetailsRequestHandler : IRequestHandler<GetSpectacularLocationImagesWithDetailsRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetSpectacularLocationImagesWithDetailsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetSpectacularLocationImagesWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var spectacularImage = await _unitofWork.SpectacularLocationImageRepository.GetSpectacularLocationImagesWithDetails(request.Id);
            if (spectacularImage is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            return ResponseResultDTO.SetResult(
                _mapper.Map<SpectacularLocationImagesDTO>(spectacularImage),
                StatusMessage.Success,
                null
                );
        }
    }
}

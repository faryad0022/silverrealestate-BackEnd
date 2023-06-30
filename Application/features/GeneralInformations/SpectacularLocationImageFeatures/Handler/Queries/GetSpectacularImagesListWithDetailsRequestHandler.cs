using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Handler.Queries
{
    public class GetSpectacularImagesListWithDetailsRequestHandler : IRequestHandler<GetSpectacularImagesListWithDetailsRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetSpectacularImagesListWithDetailsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetSpectacularImagesListWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var spectacularImagesList = await _unitofWork.SpectacularLocationImageRepository.GetSpectacularLocationImagesListWithDetails();
            if (spectacularImagesList is null || spectacularImagesList.Count < 1)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);
            if (request.justSelected)
            {
                var spectacularImageSelected = spectacularImagesList.Where(s => s.IsSelected).ToList();
                return ResponseResultDTO.SetResult(
                _mapper.Map<List<SpectacularLocationImagesDTO>>(spectacularImageSelected),
                StatusMessage.Success,
                null
                );
            }
            return ResponseResultDTO.SetResult(
                _mapper.Map<List<SpectacularLocationImagesDTO>>(spectacularImagesList),
                StatusMessage.Success,
                null
                );
        }
    }
}

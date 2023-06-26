using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Handler.Queries
{
    public class GetSpectacularLocationImagesWithDetailsRequestHandler : IRequestHandler<GetSpectacularLocationImagesWithDetailsRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetSpectacularLocationImagesWithDetailsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(GetSpectacularLocationImagesWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var spectacularImage = await _unitofWork.SpectacularLocationImageRepository.GetSpectacularLocationImagesWithDetails(request.Id);
            if (spectacularImage is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            return ResponseResult.SetResult(
                _mapper.Map<SpectacularLocationImagesDTO>(spectacularImage),
                StatusMessage.Success,
                null
                );
        }
    }
}

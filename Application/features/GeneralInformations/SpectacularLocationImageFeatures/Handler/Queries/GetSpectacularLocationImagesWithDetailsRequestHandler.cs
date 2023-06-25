using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Handler.Queries
{
    public class GetSpectacularLocationImagesWithDetailsRequestHandler : IRequestHandler<GetSpectacularLocationImagesWithDetailsRequest, ReturnData<SpectacularLocationImagesDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetSpectacularLocationImagesWithDetailsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<SpectacularLocationImagesDTO>> Handle(GetSpectacularLocationImagesWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var spectacularImage = await _unitofWork.SpectacularLocationImageRepository.GetSpectacularLocationImagesWithDetails(request.Id);
            if (spectacularImage is null)
                return SetReturnData<SpectacularLocationImagesDTO>.SetTEntity(null, ResponseStatus.NotFound, null);
            return SetReturnData<SpectacularLocationImagesDTO>.SetTEntity(
                _mapper.Map<SpectacularLocationImagesDTO>(spectacularImage),
                ResponseStatus.Success,
                null
                );
        }
    }
}

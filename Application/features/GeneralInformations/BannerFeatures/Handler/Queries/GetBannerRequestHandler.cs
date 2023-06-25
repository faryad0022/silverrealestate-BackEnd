using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.GeneralInformations.BannerFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.BannerFeatures.Handler.Queries
{
    public class GetBannerRequestHandler : IRequestHandler<GetBannerRequest, ReturnData<BannerDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBannerRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<BannerDTO>> Handle(GetBannerRequest request, CancellationToken cancellationToken)
        {
            var banner = await _unitofWork.BannerRepository.GetEntityAsync(request.Id);
            if (banner is null)
                return SetReturnData<BannerDTO>.SetTEntity(null, ResponseStatus.NotFound, null);
            var bannerDTO = _mapper.Map<BannerDTO>(banner);
            return SetReturnData<BannerDTO>.SetTEntity(bannerDTO, ResponseStatus.Success, null);
        }
    }
}

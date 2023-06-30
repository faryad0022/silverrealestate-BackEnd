using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.GeneralInformations.BannerFeatures.Request.Queries;
using Application.Models.FilterModels;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.BannerFeatures.Handler.Queries
{
    public class GetFilterBannerRequestHandler : IRequestHandler<GetFilterBannerRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetFilterBannerRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetFilterBannerRequest request, CancellationToken cancellationToken)
        {
            var filter = _mapper.Map<FilterBanner>(request.filter);
            var filterredBanner = await _unitofWork.BannerRepository.FilterBanners(filter);
            var filteredBannerDTO = _mapper.Map<FilterBannerDTO>(filterredBanner);
            if (filterredBanner.Banners is null || filterredBanner.Banners.Count < 1)
                return ResponseResultDTO.SetResult(filteredBannerDTO, StatusMessage.NoContent, null);

            return ResponseResultDTO.SetResult(filteredBannerDTO, StatusMessage.Success, null);
        }
    }
}

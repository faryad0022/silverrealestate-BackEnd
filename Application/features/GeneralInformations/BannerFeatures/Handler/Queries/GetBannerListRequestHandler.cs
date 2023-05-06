using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.features.GeneralInformations.BannerFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.BannerFeatures.Handler.Queries
{
    public class GetBannerListRequestHandler : IRequestHandler<GetBannerListRequest, ReturnData<BannerDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBannerListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<BannerDTO>> Handle(GetBannerListRequest request, CancellationToken cancellationToken)
        {
            var bannerList = await _unitofWork.BannerRepository.GetAllAsync();
            if (bannerList is null || bannerList.Count == 0)
                return FillRetuenData<BannerDTO>.FillByEntity(null, ResponseStatus.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedBanner = bannerList.Where(x => x.IsSelected).ToList();
                var SelectedBannerDTo = _mapper.Map<List<BannerDTO>>(selectedBanner);
                return FillRetuenData<BannerDTO>.FillByListEntity(SelectedBannerDTo, ResponseStatus.Success, null);
            }
            var bannerListDTO = _mapper.Map<List<BannerDTO>>(bannerList);
            return FillRetuenData<BannerDTO>.FillByListEntity(bannerListDTO, ResponseStatus.Success, null);
        }
    }
}

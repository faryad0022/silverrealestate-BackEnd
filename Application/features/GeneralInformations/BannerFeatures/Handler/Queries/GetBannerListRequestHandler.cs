using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.GeneralInformations.BannerFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.BannerFeatures.Handler.Queries
{
    public class GetBannerListRequestHandler : IRequestHandler<GetBannerListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBannerListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetBannerListRequest request, CancellationToken cancellationToken)
        {
            var bannerList = await _unitofWork.BannerRepository.GetAllAsync();
            if (request.justShowSelected)
                bannerList = bannerList.Where(x => x.IsSelected).ToList();

            if (bannerList is null || bannerList.Count == 0)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);
            var bannerListDTO = _mapper.Map<List<BannerDTO>>(bannerList.OrderByDescending(date => date.LastUpdateDate));

            return ResponseResultDTO.SetResult(bannerListDTO, StatusMessage.Success, null);
        }
    }
}

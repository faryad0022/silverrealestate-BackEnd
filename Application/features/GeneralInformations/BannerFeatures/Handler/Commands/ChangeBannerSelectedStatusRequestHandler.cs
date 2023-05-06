using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.GeneralInformations.BannerFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.BannerFeatures.Handler.Commands
{
    public class ChangeBannerSelectedStatusRequestHandler : IRequestHandler<ChangeBannerSelectedStatusRequest, ReturnData<UpdateBannerDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeBannerSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<UpdateBannerDTO>> Handle(ChangeBannerSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var banner = await _unitofWork.BannerRepository.GetEntityAsync(request.Id);
            if (banner is null)
                return FillRetuenData<UpdateBannerDTO>.FillByEntity(null, ResponseStatus.NotFound, null);
            _unitofWork.BannerRepository.ChangeSelectedStatusAsync(banner);
            await _unitofWork.SaveChangesAsync();
            var bannerDTO = _mapper.Map<UpdateBannerDTO>(banner);
            return FillRetuenData<UpdateBannerDTO>.FillByEntity(bannerDTO, ResponseStatus.Success, null);

        }
    }
}

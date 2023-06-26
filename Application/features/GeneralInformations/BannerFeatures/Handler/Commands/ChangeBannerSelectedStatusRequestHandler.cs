using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.GeneralInformations.BannerFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.BannerFeatures.Handler.Commands
{
    public class ChangeBannerSelectedStatusRequestHandler : IRequestHandler<ChangeBannerSelectedStatusRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeBannerSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(ChangeBannerSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var banner = await _unitofWork.BannerRepository.GetEntityAsync(request.Id);
            if (banner is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.BannerRepository.ChangeSelectedStatusAsync(banner);
            await _unitofWork.SaveChangesAsync();
            var bannerDTO = _mapper.Map<BannerDTO>(banner);
            return ResponseResult.SetResult(bannerDTO, StatusMessage.Success, null);

        }
    }
}

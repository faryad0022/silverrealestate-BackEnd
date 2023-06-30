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
    public class ChangeBannerSelectedStatusRequestHandler : IRequestHandler<ChangeBannerSelectedStatusRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeBannerSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(ChangeBannerSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var banner = await _unitofWork.BannerRepository.GetEntityAsync(request.Id);
            if (banner is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.BannerRepository.ChangeSelectedStatus(banner);
            await _unitofWork.SaveChangesAsync();
            var bannerDTO = _mapper.Map<BannerDTO>(banner);
            return ResponseResultDTO.SetResult(bannerDTO, StatusMessage.Success, null);

        }
    }
}

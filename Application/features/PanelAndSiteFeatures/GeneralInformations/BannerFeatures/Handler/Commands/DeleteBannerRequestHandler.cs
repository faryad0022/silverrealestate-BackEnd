using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Handler.Commands
{
    public class DeleteBannerRequestHandler : IRequestHandler<DeleteBannerRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteBannerRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeleteBannerRequest request, CancellationToken cancellationToken)
        {
            var banner = await _unitofWork.BannerRepository.GetEntityAsync(request.Id);
            if (banner is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var bannerDTO = _mapper.Map<BannerDTO>(banner);
            _unitofWork.BannerRepository.DeleteEntity(banner);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(bannerDTO, StatusMessage.Success, null);
        }
    }
}

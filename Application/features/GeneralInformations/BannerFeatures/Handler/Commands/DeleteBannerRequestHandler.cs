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
    public class DeleteBannerRequestHandler : IRequestHandler<DeleteBannerRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteBannerRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(DeleteBannerRequest request, CancellationToken cancellationToken)
        {
            var banner = await _unitofWork.BannerRepository.GetEntityAsync(request.Id);
            if (banner is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            var bannerDTO = _mapper.Map<BannerDTO>(banner);
            _unitofWork.BannerRepository.DeleteEntityAsync(banner);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(bannerDTO, StatusMessage.Success, null);
        }
    }
}

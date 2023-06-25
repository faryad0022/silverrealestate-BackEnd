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
    public class DeleteBannerRequestHandler : IRequestHandler<DeleteBannerRequest, ReturnData<BannerDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteBannerRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<BannerDTO>> Handle(DeleteBannerRequest request, CancellationToken cancellationToken)
        {
            var banner = await _unitofWork.BannerRepository.GetEntityAsync(request.Id);
            if (banner is null)
                return SetReturnData<BannerDTO>.SetTEntity(null, ResponseStatus.NotFound, null);
            var bannerDTO = _mapper.Map<BannerDTO>(banner);
            _unitofWork.BannerRepository.DeleteEntityAsync(banner);
            await _unitofWork.SaveChangesAsync();
            return SetReturnData<BannerDTO>.SetTEntity(bannerDTO, ResponseStatus.Success, null);
        }
    }
}

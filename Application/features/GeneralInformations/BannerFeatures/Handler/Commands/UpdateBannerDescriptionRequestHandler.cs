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
    public class UpdateBannerDescriptionRequestHandler : IRequestHandler<UpdateBannerDescriptionRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateBannerDescriptionRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(UpdateBannerDescriptionRequest request, CancellationToken cancellationToken)
        {
            var toUpdate = await _unitofWork.BannerRepository.GetEntityAsync(request.updateBannerDescriptionDTO.Id);
            if (toUpdate is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            toUpdate.Description = request.updateBannerDescriptionDTO.Description;
            _unitofWork.BannerRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            var toUpdateDTO = _mapper.Map<BannerDTO>(toUpdate);
            return ResponseResultDTO.SetResult(toUpdateDTO, StatusMessage.Success, null);
        }
    }
}

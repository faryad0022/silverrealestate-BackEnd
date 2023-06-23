using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.DTOs.GeneralSiteInformationsDTO.Banner.Validator;
using Application.features.GeneralInformations.BannerFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.BannerFeatures.Handler.Commands
{
    public class CreateBannerRequestHandler : IRequestHandler<CreateBannerRequest, ReturnData<BannerDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateBannerRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<BannerDTO>> Handle(CreateBannerRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreateBannerValidator();
            var validatorResult = await validator.ValidateAsync(request.createBannerDTO);
            if (!validatorResult.IsValid)
                return FillRetuenData<BannerDTO>.FillByEntity(
                    null,
                    ResponseStatus.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var banner = _mapper.Map<Banner>(request.createBannerDTO);
            await _unitofWork.BannerRepository.AddEntityAsync(banner);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<BannerDTO>.FillByEntity(_mapper.Map<BannerDTO>(banner), ResponseStatus.Success, null);
        }
    }
}

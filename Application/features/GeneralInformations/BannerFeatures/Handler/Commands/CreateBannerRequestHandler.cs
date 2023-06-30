using Application.Const.PathUtility;
using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.DTOs.GeneralSiteInformationsDTO.Banner.Validator;
using Application.Extensions;
using Application.features.GeneralInformations.BannerFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.BannerFeatures.Handler.Commands
{
    public class CreateBannerRequestHandler : IRequestHandler<CreateBannerRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateBannerRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(CreateBannerRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreateBannerValidator();
            var validatorResult = await validator.ValidateAsync(request.createBannerDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            #region Upload Image
            var createdImageName = ImageUploaderExtensions.UploadImage(
                request.createBannerDTO.BannerImage,
                PathTools.BannerServernPath
                );
            if (string.IsNullOrEmpty(createdImageName))
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.UploadError,
                    null
                    );
            #endregion
            var banner = _mapper.Map<Banner>(request.createBannerDTO);
            banner.BannerImage = createdImageName;

            await _unitofWork.BannerRepository.AddEntityAsync(banner);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<BannerDTO>(banner), StatusMessage.Success, null);
        }
    }
}

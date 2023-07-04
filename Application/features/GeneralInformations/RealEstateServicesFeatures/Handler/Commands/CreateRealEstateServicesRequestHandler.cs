using Application.Const.PathUtility;
using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess.Validators;
using Application.Extensions;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Handler.Commands
{
    public class CreateRealEstateServicesRequestHandler : IRequestHandler<CreateRealEstateServicesRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateRealEstateServicesRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(CreateRealEstateServicesRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreateRealEstateServicesDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createRealEstateServicesDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            #region Upload Image
            var createdImageName = ImageUploaderExtensions.UploadImage(
                request.createRealEstateServicesDTO.ImageName,
                PathTools.RealEstateServiceImageServerPath
                );
            if (string.IsNullOrEmpty(createdImageName))
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.UploadError,
                    null
                    );
            #endregion
            var realEstate = _mapper.Map<RealEstateServices>(request.createRealEstateServicesDTO);
            realEstate.ImageName = createdImageName;
            await _unitofWork.RealEstateServicesRepository.AddEntityAsync(realEstate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<RealEstateServicesDTO>(realEstate), StatusMessage.Success, null);
        }
    }
}

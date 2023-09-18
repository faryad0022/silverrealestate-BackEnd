using Application.Const.PathUtility;
using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyGalleries;
using Application.DTOs.Project.PropertyGalleries.Validators;
using Application.Extensions;
using Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Handler.Commands
{
    public class CreatePropertyGalleryRequestHandler : IRequestHandler<CreatePropertyGalleryRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreatePropertyGalleryRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(CreatePropertyGalleryRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreatePropertyGalleryDTOValidator(_unitofWork);
            var validatorResult = await validator.ValidateAsync(request.createPropertyGalleryDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(request.createPropertyGalleryDTO, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            #region Upload Image
            var createdImageName = ImageUploaderExtensions.UploadImage(
                request.createPropertyGalleryDTO.ImageName,
                PathTools.PropertyGalleryServerPath
                );
            if (string.IsNullOrEmpty(createdImageName))
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.UploadError,
                    null
                    );
            request.createPropertyGalleryDTO.ImageName = createdImageName;
            #endregion

            var toCreate = _mapper.Map<PropertyGallery>(request.createPropertyGalleryDTO);
            toCreate = await _unitofWork.PropertyGalleryRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<PropertyGalleryDTO>(toCreate), StatusMessage.Success, null);
        }
    }
}

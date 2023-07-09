using Application.Const.PathUtility;
using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertDTOs;
using Application.DTOs.Project.PropertDTOs.Validators;
using Application.Extensions;
using Application.features.Projects.PropertyFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyFeatures.Handler.Commands
{
    public class UpdatePropertyRequestHandler : IRequestHandler<UpdatePropertyRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdatePropertyRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(UpdatePropertyRequest request, CancellationToken cancellationToken)
        {
            var property = await _unitofWork.PropertyRepository.GetEntityAsync(request.updatePropertyDTO.Id);
            if (property is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            #region Upload Image
            if (request.updatePropertyDTO.FeatureImage != "")
            {
                var createdImageName = ImageUploaderExtensions.UploadImage(request.updatePropertyDTO.FeatureImage, PathTools.PropertyImageServerPath, property.FeatureImage);
                if (string.IsNullOrEmpty(createdImageName))
                    return ResponseResultDTO.SetResult(null, StatusMessage.UploadError, null);
                request.updatePropertyDTO.FeatureImage = createdImageName;
            }
            else
            {
                request.updatePropertyDTO.FeatureImage = property.FeatureImage;

            }
            #endregion
            #region Validator
            var validator = new UpdatePropertyDTOValidator(_unitofWork);
            var validatorResult = await validator.ValidateAsync(request.updatePropertyDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<Property>(request.updatePropertyDTO);
            _unitofWork.PropertyRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<PropertyDTO>(toUpdate), StatusMessage.Success, null);
        }
    }
}

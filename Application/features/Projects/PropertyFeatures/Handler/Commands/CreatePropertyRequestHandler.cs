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
    public class CreatePropertyRequestHandler : IRequestHandler<CreatePropertyRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreatePropertyRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(CreatePropertyRequest request, CancellationToken cancellationToken)
        {

            #region Validator
            var validator = new CreatePropertyDTOValidator(_unitofWork);
            var validatorResult = await validator.ValidateAsync(request.createPropertyDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            #region Upload Image
            var createdImageName = ImageUploaderExtensions.UploadImage(
                request.createPropertyDTO.FeatureImage,
                PathTools.PropertyImageServerPath
                );
            if (string.IsNullOrEmpty(createdImageName))
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.UploadError,
                    null
                    );
            request.createPropertyDTO.FeatureImage = createdImageName;
            #endregion
            var toCreate = _mapper.Map<Property>(request.createPropertyDTO);
            toCreate = await _unitofWork.PropertyRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            var createdDTO = _mapper.Map<PropertyDTO>(toCreate);
            return ResponseResultDTO.SetResult(createdDTO, StatusMessage.Success, null);

        }
    }
}

using Application.Const.PathUtility;
using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyGalleries.Validators;
using Application.DTOs.Project.PropertyGalleries;
using Application.Extensions;
using Application.features.Projects.PropertyPlanFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Application.DTOs.Project.PropertyPlans.Validators;
using Application.DTOs.Project.PropertyPlans;
using System.Linq;

namespace Application.features.Projects.PropertyPlanFeatures.Handler.Commands
{
    public class CreatePropertyPlanRequestHandler : IRequestHandler<CreatePropertyPlanRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreatePropertyPlanRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(CreatePropertyPlanRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreatePropertyPlanDTOValidator(_unitofWork);
            var validatorResult = await validator.ValidateAsync(request.createPropertyPlanDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(request.createPropertyPlanDTO, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            #region Upload Image
            var createdImageName = ImageUploaderExtensions.UploadImage(
                request.createPropertyPlanDTO.PlanImage,
                PathTools.PropertyPlanServerPath
                );
            if (string.IsNullOrEmpty(createdImageName))
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.UploadError,
                    null
                    );
            request.createPropertyPlanDTO.PlanImage = createdImageName;
            #endregion

            var toCreate = _mapper.Map<PropertyPlan>(request.createPropertyPlanDTO);
            toCreate = await _unitofWork.PropertyPlanRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<PropertyPlanDTO>(toCreate), StatusMessage.Success, null);
        }
    }
}

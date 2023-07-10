using Application.Const.PathUtility;
using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyPlans;
using Application.DTOs.Project.PropertyPlans.Validators;
using Application.Extensions;
using Application.features.Projects.PropertyPlanFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyPlanFeatures.Handler.Commands
{
    public class UpdatePropertyPlanRequestHandler : IRequestHandler<UpdatePropertyPlanRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdatePropertyPlanRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(UpdatePropertyPlanRequest request, CancellationToken cancellationToken)
        {
            var propertyPlan = await _unitofWork.PropertyPlanRepository.GetEntityAsync(request.updatePropertyPlanDTO.Id);
            if (propertyPlan is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            #region Upload Image
            if (request.updatePropertyPlanDTO.PlanImage != "")
            {
                var createdImageName = ImageUploaderExtensions.UploadImage(request.updatePropertyPlanDTO.PlanImage, PathTools.PropertyPlanServerPath, propertyPlan.PlanImage);
                if (string.IsNullOrEmpty(createdImageName))
                    return ResponseResultDTO.SetResult(null, StatusMessage.UploadError, null);
                request.updatePropertyPlanDTO.PlanImage = createdImageName;
            }
            else
            {
                request.updatePropertyPlanDTO.PlanImage = propertyPlan.PlanImage;

            }
            #endregion
            #region Validator
            var validator = new UpdatePropertyPlanDTOValidator(_unitofWork);
            var validatorResult = await validator.ValidateAsync(request.updatePropertyPlanDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<PropertyPlan>(request.updatePropertyPlanDTO);
            _unitofWork.PropertyPlanRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<PropertyPlanDTO>(toUpdate), StatusMessage.Success, null);
        }
    }
}

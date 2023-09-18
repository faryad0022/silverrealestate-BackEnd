using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyType;
using Application.DTOs.Project.PropertyType.Validators;
using Application.features.PanelAndSiteFeatures.Projects.PropertyTypeFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyTypeFeatures.Handler.Commands
{
    public class CreatePropertyTypeRequestHandler : IRequestHandler<CreatePropertyTypeRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreatePropertyTypeRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(CreatePropertyTypeRequest request, CancellationToken cancellationToken)
        {
            #region Validator
            var validator = new CreatePropertyTypeDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createPropertyTypeDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toCreate = _mapper.Map<PropertyType>(request.createPropertyTypeDTO);
            toCreate = await _unitofWork.PropertyTypeRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            var createdDTO = _mapper.Map<PropertyTypeDTO>(toCreate);
            return ResponseResultDTO.SetResult(createdDTO, StatusMessage.Success, null);

        }
    }
}

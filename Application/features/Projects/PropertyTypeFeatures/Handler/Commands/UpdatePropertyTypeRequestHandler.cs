using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyType.Validators;
using Application.features.Projects.PropertyTypeFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyTypeFeatures.Handler.Commands
{
    public class UpdatePropertyTypeRequestHandler : IRequestHandler<UpdatePropertyTypeRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdatePropertyTypeRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(UpdatePropertyTypeRequest request, CancellationToken cancellationToken)
        {
            #region Validator
            var validator = new UpdatePropertyTypeDTOValidator(_unitofWork);
            var validatorResult = await validator.ValidateAsync(request.updatePropertyTypeDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<PropertyType>(request.updatePropertyTypeDTO);
            _unitofWork.PropertyTypeRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(request.updatePropertyTypeDTO, StatusMessage.Success, null);
        }
    }
}

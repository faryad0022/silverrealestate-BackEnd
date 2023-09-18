using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyContractType;
using Application.DTOs.Project.PropertyContractType.Validators;
using Application.features.PanelAndSiteFeatures.Projects.PropertyContractTypeFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyContractTypeFeatures.Handler.Commands
{
    public class UpdatePropertyContractTypeRequestHandler : IRequestHandler<UpdatePropertyContractTypeRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdatePropertyContractTypeRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(UpdatePropertyContractTypeRequest request, CancellationToken cancellationToken)
        {
            #region Validator
            var Validator = new UpdatePropertyContractTypeDTOValidator(_unitofWork);
            var ValidatorResult = await Validator.ValidateAsync(request.updatePropertyContractTypeDTO);
            if (!ValidatorResult.IsValid)
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, ValidatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<PropertyContractType>(request.updatePropertyContractTypeDTO);
            _unitofWork.PropertyContractTypeRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            var toUpdateDTO = _mapper.Map<PropertyContractTypeDTO>(toUpdate);
            return ResponseResultDTO.SetResult(toUpdateDTO, StatusMessage.Success, null);
        }
    }
}

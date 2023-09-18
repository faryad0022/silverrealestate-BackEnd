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
    public class CreatePropertyContractTypeRequestHandler : IRequestHandler<CreatePropertyContractTypeRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreatePropertyContractTypeRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(CreatePropertyContractTypeRequest request, CancellationToken cancellationToken)
        {
            #region Validator
            var Validator = new CreatePropertyContractTypeDTOValidator();
            var ValidatorResult = await Validator.ValidateAsync(request.createPropertyContractTypeDTO);
            if (!ValidatorResult.IsValid)
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, ValidatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toCreate = _mapper.Map<PropertyContractType>(request.createPropertyContractTypeDTO);
            toCreate = await _unitofWork.PropertyContractTypeRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            var toCreateDTO = _mapper.Map<PropertyContractTypeDTO>(toCreate);
            return ResponseResultDTO.SetResult(toCreateDTO, StatusMessage.Success, null);
        }
    }
}

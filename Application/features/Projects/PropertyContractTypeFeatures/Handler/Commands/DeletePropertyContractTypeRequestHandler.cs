using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyContractType;
using Application.features.Projects.PropertyContractTypeFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyContractTypeFeatures.Handler.Commands
{
    public class DeletePropertyContractTypeRequestHandler : IRequestHandler<DeletePropertyContractTypeRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeletePropertyContractTypeRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(DeletePropertyContractTypeRequest request, CancellationToken cancellationToken)
        {
            var propertyContractType = await _unitofWork.PropertyContractTypeRepository.GetEntityAsync(request.Id);
            if (propertyContractType is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.PropertyContractTypeRepository.DeleteEntity(propertyContractType);
            await _unitofWork.SaveChangesAsync();
            var propertyContractTypeDTO = _mapper.Map<PropertyContractTypeDTO>(propertyContractType);
            return ResponseResultDTO.SetResult(propertyContractTypeDTO, StatusMessage.Success, null);
        }
    }
}

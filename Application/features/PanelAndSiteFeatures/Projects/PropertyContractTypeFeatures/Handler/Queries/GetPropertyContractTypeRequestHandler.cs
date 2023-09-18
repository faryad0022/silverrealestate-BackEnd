using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyContractType;
using Application.features.PanelAndSiteFeatures.Projects.PropertyContractTypeFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyContractTypeFeatures.Handler.Queries
{
    public class GetPropertyContractTypeRequestHandler : IRequestHandler<GetPropertyContractTypeRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyContractTypeRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetPropertyContractTypeRequest request, CancellationToken cancellationToken)
        {
            var contractType = await _unitofWork.PropertyContractTypeRepository.GetEntityAsync(request.Id);
            if (contractType is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var contractTypeDTO = _mapper.Map<PropertyContractTypeDTO>(contractType);
            return ResponseResultDTO.SetResult(contractTypeDTO, StatusMessage.Success, null);

        }
    }
}

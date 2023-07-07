using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyContractType;
using Application.features.Projects.PropertyContractTypeFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyContractTypeFeatures.Handler.Queries
{
    public class GetPropertyContractTypeListRequestHandler : IRequestHandler<GetPropertyContractTypeListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyContractTypeListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetPropertyContractTypeListRequest request, CancellationToken cancellationToken)
        {
            var contractTypeList = await _unitofWork.PropertyContractTypeRepository.GetAllAsync();
            if (request.justSelected)
                contractTypeList = contractTypeList.Where(c => c.IsSelected).ToList();
            if (contractTypeList is null || contractTypeList.Count < 1)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);
            var contractTypeListDTO = _mapper.Map<List<PropertyContractTypeDTO>>(contractTypeList);
            return ResponseResultDTO.SetResult(contractTypeListDTO, StatusMessage.Success, null);
        }
    }
}

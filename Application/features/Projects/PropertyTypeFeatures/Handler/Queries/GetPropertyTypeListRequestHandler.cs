using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyType;
using Application.features.Projects.PropertyTypeFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyTypeFeatures.Handler.Queries
{
    public class GetPropertyTypeListRequestHandler : IRequestHandler<GetPropertyTypeListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyTypeListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetPropertyTypeListRequest request, CancellationToken cancellationToken)
        {
            var propertyTypeList = await _unitofWork.PropertyTypeRepository.GetAllAsync();
            if (request.justSelected)
                propertyTypeList = propertyTypeList.Where(c => c.IsSelected).ToList();
            var propertyTypeDTO = _mapper.Map<List<PropertyTypeDTO>>(propertyTypeList);
            if (propertyTypeList is null || propertyTypeList.Count < 1)
                return ResponseResultDTO.SetResult(propertyTypeDTO, StatusMessage.NoContent, null);
            return ResponseResultDTO.SetResult(propertyTypeDTO, StatusMessage.Success, null);

        }
    }
}

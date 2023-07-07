using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyType;
using Application.features.Projects.PropertyTypeFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyTypeFeatures.Handler.Queries
{
    public class GetPropertyTypeRequestHandler : IRequestHandler<GetPropertyTypeRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyTypeRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetPropertyTypeRequest request, CancellationToken cancellationToken)
        {
            var propertyType = await _unitofWork.PropertyTypeRepository.GetEntityAsync(request.Id);
            var propertyTypeDTo = _mapper.Map<PropertyTypeDTO>(propertyType);
            if (propertyType == null)
                return ResponseResultDTO.SetResult(propertyTypeDTo, StatusMessage.NotFound, null);
            return ResponseResultDTO.SetResult(propertyTypeDTo, StatusMessage.Success, null);
        }
    }
}

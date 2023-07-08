using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertDTOs;
using Application.features.Projects.PropertyFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyFeatures.Handler.Queries
{
    public class GetPropertyRequestWithDetailsHandler : IRequestHandler<GetPropertyWithDetailsRequest, ResponseResultDTO>
    {

        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyRequestWithDetailsHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetPropertyWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var property = await _unitofWork.PropertyRepository.GetPropertyWithDetails(request.Id);
            var propertyDTo = _mapper.Map<PropertyDTO>(property);
            if (property == null)
                return ResponseResultDTO.SetResult(propertyDTo, StatusMessage.NotFound, null);
            return ResponseResultDTO.SetResult(propertyDTo, StatusMessage.Success, null);
        }
    }
}

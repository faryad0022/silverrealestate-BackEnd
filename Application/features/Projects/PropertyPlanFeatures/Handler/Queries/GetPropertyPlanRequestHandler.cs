using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyPlans;
using Application.features.Projects.PropertyPlanFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyPlanFeatures.Handler.Queries
{
    public class GetPropertyPlanRequestHandler : IRequestHandler<GetPropertyPlanRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyPlanRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetPropertyPlanRequest request, CancellationToken cancellationToken)
        {
            var propertyPlan = await _unitofWork.PropertyPlanRepository.GetEntityAsync(request.Id);
            if (propertyPlan is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var propertyPlanDTO = _mapper.Map<PropertyPlanDTO>(propertyPlan);
            return ResponseResultDTO.SetResult(propertyPlanDTO, StatusMessage.Success, null);
        }
    }
}

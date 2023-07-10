using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyPlans;
using Application.features.Projects.PropertyPlanFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyPlanFeatures.Handler.Commands
{
    public class DeletePropertyPlanRequestHandler : IRequestHandler<DeletePropertyPlanRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeletePropertyPlanRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeletePropertyPlanRequest request, CancellationToken cancellationToken)
        {
            var propertyPlan = await _unitofWork.PropertyPlanRepository.GetEntityAsync(request.Id);
            if (propertyPlan is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.PropertyPlanRepository.DeleteEntity(propertyPlan);
            await _unitofWork.SaveChangesAsync();
            var propertyPlanDTO = _mapper.Map<PropertyPlanDTO>(propertyPlan);
            return ResponseResultDTO.SetResult(propertyPlanDTO, StatusMessage.Success, null);
        }
    }
}

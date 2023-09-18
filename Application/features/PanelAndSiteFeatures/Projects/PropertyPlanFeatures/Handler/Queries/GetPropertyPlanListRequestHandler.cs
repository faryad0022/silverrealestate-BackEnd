using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyPlans;
using Application.features.PanelAndSiteFeatures.Projects.PropertyPlanFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyPlanFeatures.Handler.Queries
{
    public class GetPropertyPlanListRequestHandler : IRequestHandler<GetPropertyPlanListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyPlanListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetPropertyPlanListRequest request, CancellationToken cancellationToken)
        {
            var propertyPlanList = await _unitofWork.PropertyPlanRepository.GetListOfPlanOfProperty(request.PropertyId);
            if (request.Selected)
                propertyPlanList = propertyPlanList.Where(c => c.IsSelected).ToList();
            if (propertyPlanList is null || propertyPlanList.Count < 1)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);

            var propertyPlanListDTO = _mapper.Map<List<PropertyPlanDTO>>(propertyPlanList);
            return ResponseResultDTO.SetResult(propertyPlanListDTO, StatusMessage.Success, null);

        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.Facility;
using Application.features.PanelAndSiteFeatures.Projects.FacilityFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.FacilityFeatures.Handler.Queries
{
    public class GetFacilityListRequestHandler : IRequestHandler<GetFacilityListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetFacilityListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetFacilityListRequest request, CancellationToken cancellationToken)
        {
            var propertyFacilityList = await _unitofWork.FacilityRepository.GetAllAsync();
            if (request.Selected)
                propertyFacilityList = propertyFacilityList.Where(c => c.IsSelected).ToList();
            if (propertyFacilityList is null || propertyFacilityList.Count < 1)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);

            var propertyFacilityListDTO = _mapper.Map<List<FacilityDTO>>(propertyFacilityList);
            return ResponseResultDTO.SetResult(propertyFacilityListDTO, StatusMessage.Success, null);

        }
    }
}

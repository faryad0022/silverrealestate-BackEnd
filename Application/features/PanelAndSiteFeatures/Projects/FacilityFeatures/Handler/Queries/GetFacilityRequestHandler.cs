using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.Facility;
using Application.features.PanelAndSiteFeatures.Projects.FacilityFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.FacilityFeatures.Handler.Queries
{
    public class GetFacilityRequestHandler : IRequestHandler<GetFacilityRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetFacilityRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetFacilityRequest request, CancellationToken cancellationToken)
        {
            var propertyFacility = await _unitofWork.FacilityRepository.GetEntityAsync(request.Id);
            if (propertyFacility is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var propertyFacilityDTO = _mapper.Map<FacilityDTO>(propertyFacility);
            return ResponseResultDTO.SetResult(propertyFacilityDTO, StatusMessage.Success, null);
        }
    }
}

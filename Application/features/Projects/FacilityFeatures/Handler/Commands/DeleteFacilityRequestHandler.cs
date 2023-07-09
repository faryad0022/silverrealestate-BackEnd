using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.Facility;
using Application.features.Projects.FacilityFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.FacilityFeatures.Handler.Commands
{
    public class DeleteFacilityRequestHandler : IRequestHandler<DeleteFacilityRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteFacilityRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeleteFacilityRequest request, CancellationToken cancellationToken)
        {
            var propertyFacility = await _unitofWork.FacilityRepository.GetEntityAsync(request.Id);
            if (propertyFacility is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.FacilityRepository.DeleteEntity(propertyFacility);
            await _unitofWork.SaveChangesAsync();
            var propertyFacilityDTO = _mapper.Map<FacilityDTO>(propertyFacility);
            return ResponseResultDTO.SetResult(propertyFacilityDTO, StatusMessage.Success, null);
        }
    }
}

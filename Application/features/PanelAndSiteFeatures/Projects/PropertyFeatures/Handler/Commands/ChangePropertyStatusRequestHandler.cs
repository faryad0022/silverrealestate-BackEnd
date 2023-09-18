using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertDTOs;
using Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Handler.Commands
{
    public class ChangePropertyStatusRequestHandler : IRequestHandler<ChangePropertyStatusRequest, ResponseResultDTO>
    {
        private IMapper _mapper;
        private IUnitofWork _unitofWork;


        public ChangePropertyStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(ChangePropertyStatusRequest request, CancellationToken cancellationToken)
        {
            var property = await _unitofWork.PropertyRepository.GetEntityAsync(request.Id);
            if (property == null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            property.PropertyStatus = !property.PropertyStatus;
            var propertyDTO = _mapper.Map<PropertyDTO>(property);
            _unitofWork.PropertyRepository.UpdateEntity(property);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(propertyDTO, StatusMessage.Success, null);

        }
    }
}

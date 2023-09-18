using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyType;
using Application.features.PanelAndSiteFeatures.Projects.PropertyTypeFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyTypeFeatures.Handler.Commands
{
    public class DeletePropertyTypeRequestHandler : IRequestHandler<DeletePropertyTypeRequest, ResponseResultDTO>
    {
        private IMapper _mapper;
        private IUnitofWork _unitofWork;


        public DeletePropertyTypeRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(DeletePropertyTypeRequest request, CancellationToken cancellationToken)
        {
            var propertyType = await _unitofWork.PropertyTypeRepository.GetEntityAsync(request.Id);
            if (propertyType == null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var propertyTypeDTO = _mapper.Map<PropertyTypeDTO>(propertyType);
            _unitofWork.PropertyTypeRepository.DeleteEntity(propertyType);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(propertyTypeDTO, StatusMessage.Success, null);

        }
    }
}

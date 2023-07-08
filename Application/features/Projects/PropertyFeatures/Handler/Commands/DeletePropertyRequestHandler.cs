using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertDTOs;
using Application.features.Projects.PropertyFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyFeatures.Handler.Commands
{
    public class DeletePropertyRequestHandler : IRequestHandler<DeletePropertyRequest, ResponseResultDTO>
    {
        private IMapper _mapper;
        private IUnitofWork _unitofWork;


        public DeletePropertyRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(DeletePropertyRequest request, CancellationToken cancellationToken)
        {
            var property = await _unitofWork.PropertyRepository.GetEntityAsync(request.Id);
            if (property == null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var propertyDTO = _mapper.Map<PropertyDTO>(property);
            _unitofWork.PropertyRepository.DeleteEntity(property);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(propertyDTO, StatusMessage.Success, null);

        }
    }
}

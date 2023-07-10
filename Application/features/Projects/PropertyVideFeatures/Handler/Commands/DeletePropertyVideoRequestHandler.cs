using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyVideos;
using Application.features.Projects.PropertyVideFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyVideFeatures.Handler.Commands
{
    public class DeletePropertyVideoRequestHandler : IRequestHandler<DeletePropertyVideoRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeletePropertyVideoRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeletePropertyVideoRequest request, CancellationToken cancellationToken)
        {
            var propertyVideo = await _unitofWork.PropertyVideoRepository.GetEntityAsync(request.Id);
            if (propertyVideo is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.PropertyVideoRepository.DeleteEntity(propertyVideo);
            await _unitofWork.SaveChangesAsync();
            var propertyVideoDTO = _mapper.Map<PropertyVideoDTO>(propertyVideo);
            return ResponseResultDTO.SetResult(propertyVideoDTO, StatusMessage.Success, null);
        }
    }
}

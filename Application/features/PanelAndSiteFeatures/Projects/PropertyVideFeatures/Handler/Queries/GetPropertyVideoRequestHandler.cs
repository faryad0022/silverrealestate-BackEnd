using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyVideos;
using Application.features.PanelAndSiteFeatures.Projects.PropertyVideFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyVideFeatures.Handler.Queries
{
    public class GetPropertyVideoRequestHandler : IRequestHandler<GetPropertyVideoRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyVideoRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetPropertyVideoRequest request, CancellationToken cancellationToken)
        {
            var propertyVideo = await _unitofWork.PropertyVideoRepository.GetEntityAsync(request.Id);
            if (propertyVideo is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var propertyVideoDTO = _mapper.Map<PropertyVideoDTO>(propertyVideo);
            return ResponseResultDTO.SetResult(propertyVideoDTO, StatusMessage.Success, null);
        }
    }
}

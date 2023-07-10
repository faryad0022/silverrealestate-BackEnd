using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyVideos;
using Application.features.Projects.PropertyVideFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyVideFeatures.Handler.Queries
{
    public class GetPropertyVideoListRequestHandler : IRequestHandler<GetPropertyVideoListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyVideoListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetPropertyVideoListRequest request, CancellationToken cancellationToken)
        {
            var propertyVideoList = await _unitofWork.PropertyVideoRepository.GetListVideoOfProperty(request.PropertyId);
            if (request.Selected)
                propertyVideoList = propertyVideoList.Where(c => c.IsSelected).ToList();
            if (propertyVideoList is null || propertyVideoList.Count < 1)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);

            var propertyVideoListDTO = _mapper.Map<List<PropertyVideoDTO>>(propertyVideoList);
            return ResponseResultDTO.SetResult(propertyVideoListDTO, StatusMessage.Success, null);

        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertDTOs;
using Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Handler.Queries
{
    public class GetLatestPropertyRequestHandler : IRequestHandler<GetLatestPropertyRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetLatestPropertyRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetLatestPropertyRequest request, CancellationToken cancellationToken)
        {
            var propertyList = await _unitofWork.PropertyRepository.GetPropertyListWithDetails();
            propertyList = propertyList
                .Where(c => c.IsSelected)
                .OrderByDescending(d => d.CreateDate).Take(5).ToList();
            var propertyDTO = _mapper.Map<List<PropertyDTO>>(propertyList);
            if (propertyList is null || propertyList.Count < 1)
                return ResponseResultDTO.SetResult(propertyDTO, StatusMessage.NoContent, null);
            return ResponseResultDTO.SetResult(propertyDTO, StatusMessage.Success, null);
        }
    }
}

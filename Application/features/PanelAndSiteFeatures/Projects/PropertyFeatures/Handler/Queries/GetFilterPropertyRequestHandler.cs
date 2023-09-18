using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertDTOs;
using Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Queries;
using Application.Models.FilterModels;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Handler.Queries
{
    public class GetFilterPropertyRequestHandler : IRequestHandler<GetFilterPropertyRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetFilterPropertyRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetFilterPropertyRequest request, CancellationToken cancellationToken)
        {
            var filter = _mapper.Map<FilterProperty>(request.filterDTO);
            var propertyList = await _unitofWork.PropertyRepository.FilterProperty(filter);
            var propertyListDTO = _mapper.Map<FilterPropertyDTO>(propertyList);
            if (propertyList.Properties is null || propertyList.Properties.Count < 1)
                return ResponseResultDTO.SetResult(propertyListDTO, StatusMessage.NoContent, null);
            return ResponseResultDTO.SetResult(propertyListDTO, StatusMessage.Success, null);

        }
    }
}
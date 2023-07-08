using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertDTOs;
using Application.features.Projects.PropertyFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyFeatures.Handler.Queries
{
    public class GetPropertyListWithDetailsRequestHandler : IRequestHandler<GetPropertyListWithDetailsRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyListWithDetailsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetPropertyListWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var propertyList = await _unitofWork.PropertyRepository.GetPropertyListWithDetails();
            if (request.Selected)
                propertyList = propertyList.Where(c => c.IsSelected).ToList();
            if (request.PropertyStatus)
                propertyList = propertyList.Where(c => c.PropertyStatus).ToList();
            var propertyDTO = _mapper.Map<List<PropertyDTO>>(propertyList);
            if (propertyList is null || propertyList.Count < 1)
                return ResponseResultDTO.SetResult(propertyDTO, StatusMessage.NoContent, null);
            return ResponseResultDTO.SetResult(propertyDTO, StatusMessage.Success, null);

        }
    }
}

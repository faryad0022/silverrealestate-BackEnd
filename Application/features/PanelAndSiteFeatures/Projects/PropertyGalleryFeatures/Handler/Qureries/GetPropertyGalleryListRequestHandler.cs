using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyGalleries;
using Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Request.Qureries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Handler.Qureries
{
    public class GetPropertyGalleryListRequestHandler : IRequestHandler<GetPropertyGalleryListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyGalleryListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetPropertyGalleryListRequest request, CancellationToken cancellationToken)
        {
            var propertyGalleryList = await _unitofWork.PropertyGalleryRepository.GetPropertyGalleryList(request.PropertyId);
            if (request.Selected)
                propertyGalleryList = propertyGalleryList.Where(c => c.IsSelected).ToList();
            if (propertyGalleryList is null || propertyGalleryList.Count < 1)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);

            var propertyGalleryListDTO = _mapper.Map<List<PropertyGalleryDTO>>(propertyGalleryList);
            return ResponseResultDTO.SetResult(propertyGalleryListDTO, StatusMessage.Success, null);

        }
    }
}

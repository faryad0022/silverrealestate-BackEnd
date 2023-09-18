using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyGalleries;
using Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Request.Qureries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Handler.Qureries
{
    public class GetPropertyGalleryRequestHandler : IRequestHandler<GetPropertyGalleryRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetPropertyGalleryRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetPropertyGalleryRequest request, CancellationToken cancellationToken)
        {
            var propertyGallery = await _unitofWork.PropertyGalleryRepository.GetEntityAsync(request.Id);
            if (propertyGallery is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var propertyPropertyGalleryDTO = _mapper.Map<PropertyGalleryDTO>(propertyGallery);
            return ResponseResultDTO.SetResult(propertyPropertyGalleryDTO, StatusMessage.Success, null);
        }
    }
}

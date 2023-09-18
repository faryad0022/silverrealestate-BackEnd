using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyGalleries;
using Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Handler.Commands
{
    public class DeletePropertyGalleryRequestHandler : IRequestHandler<DeletePropertyGalleryRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeletePropertyGalleryRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeletePropertyGalleryRequest request, CancellationToken cancellationToken)
        {
            var propertyGallery = await _unitofWork.PropertyGalleryRepository.GetEntityAsync(request.Id);
            if (propertyGallery is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.PropertyGalleryRepository.DeleteEntity(propertyGallery);
            await _unitofWork.SaveChangesAsync();
            var propertyGalleryDTO = _mapper.Map<PropertyGalleryDTO>(propertyGallery);
            return ResponseResultDTO.SetResult(propertyGalleryDTO, StatusMessage.Success, null);
        }
    }
}

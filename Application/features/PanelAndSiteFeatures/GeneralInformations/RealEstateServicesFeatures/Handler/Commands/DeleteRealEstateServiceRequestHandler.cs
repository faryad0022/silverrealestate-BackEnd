using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.features.PanelAndSiteFeatures.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.RealEstateServicesFeatures.Handler.Commands
{
    public class DeleteRealEstateServiceRequestHandler : IRequestHandler<DeleteRealEstateServiceRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteRealEstateServiceRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeleteRealEstateServiceRequest request, CancellationToken cancellationToken)
        {
            var service = await _unitofWork.RealEstateServicesRepository.GetEntityAsync(request.Id);
            if (service is null)
                return ResponseResultDTO.SetResult(service, StatusMessage.NotFound, null);
            _unitofWork.RealEstateServicesRepository.DeleteEntity(service);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<RealEstateServicesDTO>(service), StatusMessage.Success, null);
        }
    }
}

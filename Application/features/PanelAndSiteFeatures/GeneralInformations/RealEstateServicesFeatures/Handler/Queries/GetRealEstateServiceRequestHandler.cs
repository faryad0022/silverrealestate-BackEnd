using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.features.PanelAndSiteFeatures.GeneralInformations.RealEstateServicesFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.RealEstateServicesFeatures.Handler.Queries
{
    public class GetRealEstateServiceRequestHandler : IRequestHandler<GetRealEstateServiceRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetRealEstateServiceRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetRealEstateServiceRequest request, CancellationToken cancellationToken)
        {
            var realEstateService = await _unitofWork.RealEstateServicesRepository.GetEntityAsync(request.Id);
            if (realEstateService is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var realEstateServiceDTO = _mapper.Map<RealEstateServicesDTO>(realEstateService);
            return ResponseResultDTO.SetResult(realEstateServiceDTO, StatusMessage.Success, null);
        }
    }
}

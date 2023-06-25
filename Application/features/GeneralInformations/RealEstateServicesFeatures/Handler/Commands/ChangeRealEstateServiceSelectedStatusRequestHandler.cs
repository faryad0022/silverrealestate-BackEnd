using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Handler.Commands
{
    public class ChangeRealEstateServiceSelectedStatusRequestHandler : IRequestHandler<ChangeRealEstateServiceSelectedStatusRequest, ReturnData<RealEstateServicesDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeRealEstateServiceSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<RealEstateServicesDTO>> Handle(ChangeRealEstateServiceSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var realEstateService = await _unitofWork.RealEstateServicesRepository.GetEntityAsync(request.Id);
            if (realEstateService is null)
                return SetReturnData<RealEstateServicesDTO>.SetTEntity(null, ResponseStatus.NotFound, null);

            _unitofWork.RealEstateServicesRepository.ChangeSelectedStatusAsync(realEstateService);
            await _unitofWork.SaveChangesAsync();
            var realEstateServiceDTO = _mapper.Map<RealEstateServicesDTO>(realEstateService);
            return SetReturnData<RealEstateServicesDTO>.SetTEntity(realEstateServiceDTO, ResponseStatus.Success, null);
        }
    }
}

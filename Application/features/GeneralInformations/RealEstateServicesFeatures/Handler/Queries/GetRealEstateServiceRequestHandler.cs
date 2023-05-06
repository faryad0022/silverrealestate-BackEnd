﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Handler.Queries
{
    public class GetRealEstateServiceRequestHandler : IRequestHandler<GetRealEstateServiceRequest, ReturnData<RealEstateServicesDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetRealEstateServiceRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<RealEstateServicesDTO>> Handle(GetRealEstateServiceRequest request, CancellationToken cancellationToken)
        {
            var realEstateService = await _unitofWork.RealEstateServicesRepository.GetEntityAsync(request.Id);
            if (realEstateService is null)
                return FillRetuenData<RealEstateServicesDTO>.FillByEntity(null, ResponseStatus.NotFound, null);
            var realEstateServiceDTO = _mapper.Map<RealEstateServicesDTO>(realEstateService);
            return FillRetuenData<RealEstateServicesDTO>.FillByEntity(realEstateServiceDTO, ResponseStatus.Success, null);
        }
    }
}

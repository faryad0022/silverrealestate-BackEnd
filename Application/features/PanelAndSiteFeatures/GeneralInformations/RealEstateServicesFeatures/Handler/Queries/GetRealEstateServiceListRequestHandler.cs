﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.features.PanelAndSiteFeatures.GeneralInformations.RealEstateServicesFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.RealEstateServicesFeatures.Handler.Queries
{
    public class GetRealEstateServiceListRequestHandler : IRequestHandler<GetRealEstateServiceListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetRealEstateServiceListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetRealEstateServiceListRequest request, CancellationToken cancellationToken)
        {
            var realEstateServiceList = await _unitofWork.RealEstateServicesRepository.GetAllAsync();
            if (realEstateServiceList is null || realEstateServiceList.Count < 1)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);
            if (request.justShowSelected)
                realEstateServiceList = realEstateServiceList.Where(q => q.IsSelected).ToList();
            var realEstateServiceListDTO = _mapper.Map<List<RealEstateServicesDTO>>(realEstateServiceList);
            return ResponseResultDTO.SetResult(realEstateServiceListDTO, StatusMessage.Success, null);
        }
    }
}
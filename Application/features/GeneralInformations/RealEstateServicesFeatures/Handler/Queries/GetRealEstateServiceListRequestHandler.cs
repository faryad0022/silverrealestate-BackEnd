using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Handler.Queries
{
    public class GetRealEstateServiceListRequestHandler : IRequestHandler<GetRealEstateServiceListRequest, ReturnData<RealEstateServicesDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetRealEstateServiceListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<RealEstateServicesDTO>> Handle(GetRealEstateServiceListRequest request, CancellationToken cancellationToken)
        {
            var realEstateServiceList = await _unitofWork.RealEstateServicesRepository.GetAllAsync();
            if (realEstateServiceList is null || realEstateServiceList.Count < 1)
                return FillRetuenData<RealEstateServicesDTO>.FillByListEntity(null, ResponseStatus.NoContent, null);
            if (request.justShowSelected)
                realEstateServiceList = realEstateServiceList.Where(q => q.IsSelected).ToList();
            var realEstateServiceListDTO = _mapper.Map<List<RealEstateServicesDTO>>(realEstateServiceList);
            return FillRetuenData<RealEstateServicesDTO>.FillByListEntity(realEstateServiceListDTO, ResponseStatus.Success, null);
        }
    }
}

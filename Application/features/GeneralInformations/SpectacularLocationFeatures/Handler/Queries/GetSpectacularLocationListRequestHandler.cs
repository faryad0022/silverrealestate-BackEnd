using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Handler.Queries
{
    public class GetSpectacularLocationListRequestHandler : IRequestHandler<GetSpectacularLocationListRequest, ReturnData<SpectacularLocationDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetSpectacularLocationListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<SpectacularLocationDTO>> Handle(GetSpectacularLocationListRequest request, CancellationToken cancellationToken)
        {
            var specatularLocationList = await _unitofWork.SpectacularlocationRepository.GetAllAsync();

            if (specatularLocationList is null || specatularLocationList.Count < 1)
                SetReturnData<SpectacularLocationDTO>.SetTEntities(null, ResponseStatus.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedSpectacularLocation = specatularLocationList.Where(s => s.IsSelected).ToList();
                var selectedSpectacularLocationDTO = _mapper.Map<List<SpectacularLocationDTO>>(selectedSpectacularLocation);
                return SetReturnData<SpectacularLocationDTO>.SetTEntities(selectedSpectacularLocationDTO, ResponseStatus.Success, null);
            }
            var specatularLocationListDTO = _mapper.Map<List<SpectacularLocationDTO>>(specatularLocationList);
            return SetReturnData<SpectacularLocationDTO>.SetTEntities(specatularLocationListDTO, ResponseStatus.Success, null);
        }
    }
}

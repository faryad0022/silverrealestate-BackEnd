using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Handler.Queries
{
    public class GetSpectacularLocationListRequestHandler : IRequestHandler<GetSpectacularLocationListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetSpectacularLocationListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetSpectacularLocationListRequest request, CancellationToken cancellationToken)
        {
            var specatularLocationList = await _unitofWork.SpectacularlocationRepository.GetAllAsync();

            if (specatularLocationList is null || specatularLocationList.Count < 1)
               return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedSpectacularLocation = specatularLocationList.Where(s => s.IsSelected).ToList();
                var selectedSpectacularLocationDTO = _mapper.Map<List<SpectacularLocationDTO>>(selectedSpectacularLocation);
                return ResponseResultDTO.SetResult(selectedSpectacularLocationDTO, StatusMessage.Success, null);
            }
            var specatularLocationListDTO = _mapper.Map<List<SpectacularLocationDTO>>(specatularLocationList);
            return ResponseResultDTO.SetResult(specatularLocationListDTO, StatusMessage.Success, null);
        }
    }
}

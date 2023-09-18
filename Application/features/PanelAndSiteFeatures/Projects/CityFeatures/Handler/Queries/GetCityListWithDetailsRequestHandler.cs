using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.City;
using Application.features.PanelAndSiteFeatures.Projects.CityFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.CityFeatures.Handler.Queries
{
    public class GetCityListWithDetailsRequestHandler : IRequestHandler<GetCityListWithDetailsRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetCityListWithDetailsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetCityListWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var cityList = await _unitofWork.CityRepository.GetCityListWithDetailsAsync();
            if (cityList is null || cityList.Count < 1)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);
            var cityListDTO = _mapper.Map<List<CityDTO>>(cityList);
            return ResponseResultDTO.SetResult(cityListDTO, StatusMessage.Success, null);

        }
    }
}

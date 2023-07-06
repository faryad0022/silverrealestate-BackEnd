using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.City;
using Application.features.Projects.CityFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.CityFeatures.Handler.Queries
{
    public class GetCityListOfCountryWithDetailsRequestHandler : IRequestHandler<GetCityListOfCountryWithDetailsRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetCityListOfCountryWithDetailsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetCityListOfCountryWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var cityList = await _unitofWork.CityRepository.GetCityListOfCountryWithDetailsAsync(request.countryId);
            if (cityList is null || cityList.Count<1)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var cityListDTO = _mapper.Map<List<CityDTO>>(cityList);
            return ResponseResultDTO.SetResult(cityListDTO, StatusMessage.Success, null);
        }
    }
}

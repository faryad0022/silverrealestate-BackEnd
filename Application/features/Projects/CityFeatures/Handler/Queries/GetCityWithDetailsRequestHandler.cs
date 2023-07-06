using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.City;
using Application.features.Projects.CityFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.CityFeatures.Handler.Queries
{
    public class GetCityWithDetailsRequestHandler : IRequestHandler<GetCityWithDetailsRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetCityWithDetailsRequestHandler(IMapper mapper,IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetCityWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var city = await _unitofWork.CityRepository.GetCityWithDetailsAsync(request.cityId);
            if (city is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var cityDTO = _mapper.Map<CityDTO>(city);
            return ResponseResultDTO.SetResult(cityDTO, StatusMessage.Success, null);
        }
    }
}

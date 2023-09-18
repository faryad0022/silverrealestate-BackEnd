using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.City;
using Application.features.PanelAndSiteFeatures.Projects.CityFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.CityFeatures.Handler.Queries
{
    public class GetCityRequestHandler : IRequestHandler<GetCityRequest, ResponseResultDTO>
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public GetCityRequestHandler(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        public async Task<ResponseResultDTO> Handle(GetCityRequest request, CancellationToken cancellationToken)
        {
            var city = await _unitofWork.CityRepository.GetEntityAsync(request.Id);
            if (city is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var cityDTO = _mapper.Map<CityDTO>(city);
            return ResponseResultDTO.SetResult(cityDTO, StatusMessage.Success, null);
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.City;
using Application.features.PanelAndSiteFeatures.Projects.CityFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.Projects.CityFeatures.Handler.Commands
{
    public class DeleteCityRequestHandler : IRequestHandler<DeleteCityRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteCityRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeleteCityRequest request, CancellationToken cancellationToken)
        {
            var city = await _unitofWork.CityRepository.GetEntityAsync(request.Id);
            if (city is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.CityRepository.DeleteEntity(city);
            await _unitofWork.SaveChangesAsync();
            var cityDTO = _mapper.Map<CityDTO>(city);
            return ResponseResultDTO.SetResult(cityDTO, StatusMessage.Success, null);
        }
    }
}

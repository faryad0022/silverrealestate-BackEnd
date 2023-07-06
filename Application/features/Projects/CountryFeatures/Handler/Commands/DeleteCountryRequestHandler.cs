using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.Country;
using Application.features.Projects.CountryFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.CountryFeatures.Handler.Commands
{
    public class DeleteCountryRequestHandler : IRequestHandler<DeleteCountryRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteCountryRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeleteCountryRequest request, CancellationToken cancellationToken)
        {
            var country = await _unitofWork.CountryRepository.GetEntityAsync(request.Id);
            if (country is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.CountryRepository.DeleteEntity(country);
            await _unitofWork.SaveChangesAsync();
            var countryDTO = _mapper.Map<CountryDTO>(country);
            return ResponseResultDTO.SetResult(countryDTO, StatusMessage.Success, null);
        }
    }
}

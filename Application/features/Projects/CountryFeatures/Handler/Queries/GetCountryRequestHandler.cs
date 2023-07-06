using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.Country;
using Application.features.Projects.CountryFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.CountryFeatures.Handler.Queries
{
    public class GetCountryRequestHandler : IRequestHandler<GetCountryRequest, ResponseResultDTO>
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public GetCountryRequestHandler(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        public async Task<ResponseResultDTO> Handle(GetCountryRequest request, CancellationToken cancellationToken)
        {
            var country = await _unitofWork.CountryRepository.GetEntityAsync(request.Id);
            if (country is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var countryDTO = _mapper.Map<CountryDTO>(country);
            return ResponseResultDTO.SetResult(countryDTO, StatusMessage.Success, null);
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.Country;
using Application.features.Projects.CountryFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.CountryFeatures.Handler.Queries
{
    public class GetCountryListRequestHandler : IRequestHandler<GetCountryListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetCountryListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetCountryListRequest request, CancellationToken cancellationToken)
        {
            var countryList = await _unitofWork.CountryRepository.GetAllAsync();
            if (request.justShowSelected)
                countryList = countryList.Where(c => c.IsSelected).ToList();
            if (countryList is null || countryList.Count < 1)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);

            var countryListDTO = _mapper.Map<List<CountryDTO>>(countryList);
            return ResponseResultDTO.SetResult(countryListDTO, StatusMessage.Success, null);

        }
    }
}

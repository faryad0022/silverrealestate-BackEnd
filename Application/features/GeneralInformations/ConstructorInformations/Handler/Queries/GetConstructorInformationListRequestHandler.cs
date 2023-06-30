using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.features.GeneralInformations.ConstructorInformations.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.ConstructorInformations.Handler.Queries
{
    public class GetConstructorInformationListRequestHandler : IRequestHandler<GetConstructorInformationListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetConstructorInformationListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetConstructorInformationListRequest request, CancellationToken cancellationToken)
        {
            var constructorInformatiList = await _unitofWork.ConstructorInfromationRepository.GetAllAsync();
            if (constructorInformatiList is null || constructorInformatiList.Count == 0)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedConstructorInformation = constructorInformatiList.Where(x => x.IsSelected).ToList();
                var selectedConstructorInformationDTO = _mapper.Map<List<ConstructorInformationDTO>>(selectedConstructorInformation);
                return ResponseResultDTO.SetResult(selectedConstructorInformationDTO, StatusMessage.Success, null);
            }
            var constructorInformatiListDTO = _mapper.Map<List<ConstructorInformationDTO>>(constructorInformatiList);
            return ResponseResultDTO.SetResult(constructorInformatiListDTO, StatusMessage.Success, null);
        }
    }
}

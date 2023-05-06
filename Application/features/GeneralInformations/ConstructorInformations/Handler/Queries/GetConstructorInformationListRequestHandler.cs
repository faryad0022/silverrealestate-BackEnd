using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.features.GeneralInformations.ConstructorInformations.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.ConstructorInformations.Handler.Queries
{
    public class GetConstructorInformationListRequestHandler : IRequestHandler<GetConstructorInformationListRequest, ReturnData<ConstructorInformationDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetConstructorInformationListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<ConstructorInformationDTO>> Handle(GetConstructorInformationListRequest request, CancellationToken cancellationToken)
        {
            var constructorInformatiList = await _unitofWork.ConstructorInfromationRepository.GetAllAsync();
            if (constructorInformatiList is null || constructorInformatiList.Count == 0)
                return FillRetuenData<ConstructorInformationDTO>.FillByEntity(null, ResponseStatus.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedConstructorInformation = constructorInformatiList.Where(x => x.IsSelected).ToList();
                var selectedConstructorInformationDTO = _mapper.Map<List<ConstructorInformationDTO>>(selectedConstructorInformation);
                return FillRetuenData<ConstructorInformationDTO>.FillByListEntity(selectedConstructorInformationDTO, ResponseStatus.Success, null);
            }
            var constructorInformatiListDTO = _mapper.Map<List<ConstructorInformationDTO>>(constructorInformatiList);
            return FillRetuenData<ConstructorInformationDTO>.FillByListEntity(constructorInformatiListDTO, ResponseStatus.Success, null);
        }
    }
}

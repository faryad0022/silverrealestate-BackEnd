using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.features.PanelAndSiteFeatures.GeneralInformations.ConstructorInformations.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.ConstructorInformations.Handler.Queries
{
    public class GetConstructorInformationRequestHandler : IRequestHandler<GetConstructorInformationRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetConstructorInformationRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetConstructorInformationRequest request, CancellationToken cancellationToken)
        {
            var constructor = await _unitofWork.ConstructorInfromationRepository.GetEntityAsync(request.Id);
            if (constructor is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var constructorDTO = _mapper.Map<ConstructorInformationDTO>(constructor);
            return ResponseResultDTO.SetResult(constructorDTO, StatusMessage.Success, null);
        }
    }
}

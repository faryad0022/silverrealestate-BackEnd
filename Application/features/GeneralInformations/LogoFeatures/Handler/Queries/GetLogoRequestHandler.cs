using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.features.GeneralInformations.LogoFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.LogoFeatures.Handler.Queries
{
    public class GetLogoRequestHandler : IRequestHandler<GetLogoRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetLogoRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetLogoRequest request, CancellationToken cancellationToken)
        {
            var logo = await _unitofWork.LogoRepository.GetEntityAsync(request.Id);
            if (logo is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var logoDTO = _mapper.Map<LogoDTO>(logo);
            return ResponseResultDTO.SetResult(logoDTO, StatusMessage.Success, null);
        }
    }
}

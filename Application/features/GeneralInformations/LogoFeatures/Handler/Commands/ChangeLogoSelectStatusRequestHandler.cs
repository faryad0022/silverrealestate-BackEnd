using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.features.GeneralInformations.LogoFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.LogoFeatures.Handler.Commands
{
    public class ChangeLogoSelectStatusRequestHandler : IRequestHandler<ChangeLogoSelectStatusRequest, ReturnData<LogoDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeLogoSelectStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<LogoDTO>> Handle(ChangeLogoSelectStatusRequest request, CancellationToken cancellationToken)
        {
            var logo = await _unitofWork.LogoRepository.GetEntityAsync(request.Id);
            if (logo is null)
                return SetReturnData<LogoDTO>.SetTEntity(null, ResponseStatus.NotFound, null);
            _unitofWork.LogoRepository.ChangeSelectedStatusAsync(logo);
            await _unitofWork.SaveChangesAsync();
            var logoDTO = _mapper.Map<LogoDTO>(logo);
            return SetReturnData<LogoDTO>.SetTEntity(logoDTO, ResponseStatus.Success, null);
        }
    }
}

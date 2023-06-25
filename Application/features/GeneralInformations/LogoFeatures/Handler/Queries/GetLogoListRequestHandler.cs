using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.features.GeneralInformations.LogoFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.LogoFeatures.Handler.Queries
{
    public class GetLogoListRequestHandler : IRequestHandler<GetLogoListRequest, ReturnData<LogoDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetLogoListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<LogoDTO>> Handle(GetLogoListRequest request, CancellationToken cancellationToken)
        {
            var logoList = await _unitofWork.LogoRepository.GetAllAsync();
            if (logoList is null || logoList.Count == 0)
                return SetReturnData<LogoDTO>.SetTEntity(null, ResponseStatus.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedLogo = logoList.Where(x => x.IsSelected).ToList();
                var SelectedLogoDTo = _mapper.Map<List<LogoDTO>>(selectedLogo);
                return SetReturnData<LogoDTO>.SetTEntities(SelectedLogoDTo, ResponseStatus.Success, null);
            }
            var logoListDTO = _mapper.Map<List<LogoDTO>>(logoList);
            return SetReturnData<LogoDTO>.SetTEntities(logoListDTO, ResponseStatus.Success, null);
        }
    }
}

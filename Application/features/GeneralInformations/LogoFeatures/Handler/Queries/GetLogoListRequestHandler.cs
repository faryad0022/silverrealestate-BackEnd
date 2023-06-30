using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.features.GeneralInformations.LogoFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.LogoFeatures.Handler.Queries
{
    public class GetLogoListRequestHandler : IRequestHandler<GetLogoListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetLogoListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetLogoListRequest request, CancellationToken cancellationToken)
        {
            var logoList = await _unitofWork.LogoRepository.GetAllAsync();
            if (logoList is null || logoList.Count == 0)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedLogo = logoList.Where(x => x.IsSelected).ToList();
                var SelectedLogoDTo = _mapper.Map<List<LogoDTO>>(selectedLogo);
                return ResponseResultDTO.SetResult(SelectedLogoDTo, StatusMessage.Success, null);
            }
            var logoListDTO = _mapper.Map<List<LogoDTO>>(logoList);
            return ResponseResultDTO.SetResult(logoListDTO, StatusMessage.Success, null);
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.features.PanelAndSiteFeatures.GeneralInformations.AboutUsFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.AboutUsFeatures.Handler.Queries
{
    public class GetAboutUsListRequestHandler : IRequestHandler<GetAboutUsListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetAboutUsListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetAboutUsListRequest request, CancellationToken cancellationToken)
        {
            var aboutus = await _unitofWork.AboutUsRepository.GetAllAsync();
            if (aboutus is null || aboutus.Count == 0)
                return ResponseResultDTO.SetResult(null, StatusMessage.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedAboutus = aboutus.Where(x => x.IsSelected).ToList();
                var SelectedAboutusDTo = _mapper.Map<List<AboutUsDTO>>(selectedAboutus);
                return ResponseResultDTO.SetResult(SelectedAboutusDTo, StatusMessage.Success, null);
            }
            var aboutUsDTO = _mapper.Map<List<AboutUsDTO>>(aboutus);
            return ResponseResultDTO.SetResult(
                aboutUsDTO,
                StatusMessage.Success,
                null
                );

        }
    }
}

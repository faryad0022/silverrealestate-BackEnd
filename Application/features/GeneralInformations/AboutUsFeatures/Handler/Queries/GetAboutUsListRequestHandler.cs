using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AboutUsFeatures.Handler.Queries
{
    public class GetAboutUsListRequestHandler : IRequestHandler<GetAboutUsListRequest, ReturnData<AboutUsDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetAboutUsListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<AboutUsDTO>> Handle(GetAboutUsListRequest request, CancellationToken cancellationToken)
        {
            var aboutus = await _unitofWork.AboutUsRepository.GetAllAsync();
            if (aboutus is null || aboutus.Count == 0)
                return SetReturnData<AboutUsDTO>.SetTEntities(null, ResponseStatus.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedAboutus = aboutus.Where(x => x.IsSelected).ToList();
                var SelectedAboutusDTo = _mapper.Map<List<AboutUsDTO>>(selectedAboutus);
                return SetReturnData<AboutUsDTO>.SetTEntities(SelectedAboutusDTo, ResponseStatus.Success, null);
            }
            var aboutUsDTO = _mapper.Map<List<AboutUsDTO>>(aboutus);
            return SetReturnData<AboutUsDTO>.SetTEntities(
                aboutUsDTO,
                ResponseStatus.Success,
                null
                );

        }
    }
}

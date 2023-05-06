using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.GeneralInformations.SocialFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SocialFeatures.Handler.Queries
{


    public class GetSocialListRequestHandler : IRequestHandler<GetSocialListRequest, ReturnData<SocialDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetSocialListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ReturnData<SocialDTO>> Handle(GetSocialListRequest request, CancellationToken cancellationToken)
        {
            var social = await _unitofWork.SocialRepository.GetAllAsync();
            if(request.justShowSelected)
            {
                var selectedSocial = social.Where(x => x.IsSelected).ToList();
                var SelectedSocialDTo = _mapper.Map<List<SocialDTO>>(selectedSocial);
                return FillRetuenData<SocialDTO>.FillByListEntity(SelectedSocialDTo, ResponseStatus.Success, null);


            }
            var socialDTo = _mapper.Map<List<SocialDTO>>(social);
            return FillRetuenData<SocialDTO>.FillByListEntity(socialDTo, ResponseStatus.Success, null);
        }
    }

}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.GeneralInformations.SocialFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SocialFeatures.Handler.Queries
{


    public class GetSocialListRequestHandler : IRequestHandler<GetSocialListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetSocialListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetSocialListRequest request, CancellationToken cancellationToken)
        {
            var social = await _unitofWork.SocialRepository.GetAllAsync();
            if (request.justShowSelected)
            {
                var selectedSocial = social.Where(x => x.IsSelected).ToList();
                var SelectedSocialDTo = _mapper.Map<List<SocialDTO>>(selectedSocial);
                return ResponseResultDTO.SetResult(SelectedSocialDTo, StatusMessage.Success, null);


            }
            var socialDTo = _mapper.Map<List<SocialDTO>>(social);
            return ResponseResultDTO.SetResult(socialDTo, StatusMessage.Success, null);
        }
    }

}

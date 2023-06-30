using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.GeneralInformations.SocialFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SocialFeatures.Handler.Queries
{
    public class GetSocialRequestHandler : IRequestHandler<GetSocialRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetSocialRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetSocialRequest request, CancellationToken cancellationToken)
        {
            if (request.Id < 0)
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, null);

            var social = await _unitofWork.SocialRepository.GetEntityAsync(request.Id);
            if (social is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            return ResponseResultDTO.SetResult(_mapper.Map<SocialDTO>(social), StatusMessage.Success, null);
        }
    }

}

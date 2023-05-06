using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.GeneralInformations.SocialFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SocialFeatures.Handler.Queries
{
    public class GetSocialRequestHandler : IRequestHandler<GetSocialRequest, ReturnData<SocialDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetSocialRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ReturnData<SocialDTO>> Handle(GetSocialRequest request, CancellationToken cancellationToken)
        {
            if (request.Id < 0)
                return FillRetuenData<SocialDTO>.FillByEntity(null, ResponseStatus.ValidationError, null);

            var social = await _unitofWork.SocialRepository.GetEntityAsync(request.Id);
            if (social is null)
                return FillRetuenData<SocialDTO>.FillByEntity(null, ResponseStatus.NotFound, null);
            return FillRetuenData<SocialDTO>.FillByEntity(_mapper.Map<SocialDTO>(social), ResponseStatus.Success, null);
        }
    }

}

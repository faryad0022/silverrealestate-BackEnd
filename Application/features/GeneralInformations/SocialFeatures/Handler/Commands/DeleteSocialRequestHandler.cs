using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.GeneralInformations.SocialFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SocialFeatures.Handler.Commands
{
    public class DeleteSocialRequestHandler : IRequestHandler<DeleteSocialRequest, ReturnData<SocialDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteSocialRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<SocialDTO>> Handle(DeleteSocialRequest request, CancellationToken cancellationToken)
        {
            var social = await _unitofWork.SocialRepository.GetEntityAsync(request.Id);
            if (social is null)
                return FillRetuenData<SocialDTO>.FillByEntity(null, ResponseStatus.NotFound, null);
            var socialDTO = _mapper.Map<SocialDTO>(social);
            _unitofWork.SocialRepository.DeleteEntityAsync(social);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<SocialDTO>.FillByEntity(socialDTO, ResponseStatus.Success, null);
        }
    }
}

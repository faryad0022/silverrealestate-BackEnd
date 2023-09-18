using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.PanelAndSiteFeatures.GeneralInformations.SocialFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SocialFeatures.Handler.Commands
{
    public class DeleteSocialRequestHandler : IRequestHandler<DeleteSocialRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteSocialRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeleteSocialRequest request, CancellationToken cancellationToken)
        {
            var social = await _unitofWork.SocialRepository.GetEntityAsync(request.Id);
            if (social is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var socialDTO = _mapper.Map<SocialDTO>(social);
            _unitofWork.SocialRepository.DeleteEntity(social);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(socialDTO, StatusMessage.Success, null);
        }
    }
}

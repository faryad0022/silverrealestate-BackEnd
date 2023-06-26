using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.GeneralInformations.SocialFeatures.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SocialFeatures.Handler.Commands
{
    public class DeleteSocialRequestHandler : IRequestHandler<DeleteSocialRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteSocialRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(DeleteSocialRequest request, CancellationToken cancellationToken)
        {
            var social = await _unitofWork.SocialRepository.GetEntityAsync(request.Id);
            if (social is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            var socialDTO = _mapper.Map<SocialDTO>(social);
            _unitofWork.SocialRepository.DeleteEntityAsync(social);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(socialDTO, StatusMessage.Success, null);
        }
    }
}

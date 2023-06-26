using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.DTOs.GeneralSiteInformationsDTO.Social.Validators;
using Application.features.GeneralInformations.SocialFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SocialFeatures.Handler.Commands
{
    public class CreateSocialRequestHandler : IRequestHandler<CreateSocialRequest, ResponseResult>
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public CreateSocialRequestHandler(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public async Task<ResponseResult> Handle(CreateSocialRequest request, CancellationToken cancellationToken)
        {
            var social = _mapper.Map<Social>(request.createSocialDTO);
            #region Validation
            var validator = new CreateSocialDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createSocialDTO);
            if (!validatorResult.IsValid)
            {
                return ResponseResult.SetResult(
                    _mapper.Map<SocialDTO>(social),
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            }
            #endregion

            social = await _unitofWork.SocialRepository.AddEntityAsync(social);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(
                     _mapper.Map<SocialDTO>(social),
                     StatusMessage.Success,
                     null);
        }
    }
}

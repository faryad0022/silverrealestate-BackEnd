using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.DTOs.GeneralSiteInformationsDTO.Social.Validators;
using Application.features.GeneralInformations.SocialFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SocialFeatures.Handler.Commands
{
    public class UpdateSocialRequestHandler : IRequestHandler<UpdateSocialRequest, ReturnData<UpdateSocialDTO>>
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public UpdateSocialRequestHandler(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public async Task<ReturnData<UpdateSocialDTO>> Handle(UpdateSocialRequest request, CancellationToken cancellationToken)
        {

            var social = await _unitofWork.SocialRepository.GetEntityAsync(request.UpdateSocialDTO.Id);
            if (social is null)
                return FillRetuenData<UpdateSocialDTO>.FillByEntity(
                    null,
                    ResponseStatus.NotFound,
                    null
                    );

            #region Validation
            var validator = new UpdateSocialDTOValidator(_unitofWork.SocialRepository);
            var validatorResult = await validator.ValidateAsync(request.UpdateSocialDTO);
            if (!validatorResult.IsValid)
            {
                return FillRetuenData<UpdateSocialDTO>.FillByEntity(
                    null,
                    ResponseStatus.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList()
                    );
            }
            #endregion
            var toUpdate = _mapper.Map<Social>(request.UpdateSocialDTO);
            _unitofWork.SocialRepository.UpdateEntityAsync(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<UpdateSocialDTO>.FillByEntity(
                                request.UpdateSocialDTO,
                                ResponseStatus.Success,
                                null);

        }
    }
}

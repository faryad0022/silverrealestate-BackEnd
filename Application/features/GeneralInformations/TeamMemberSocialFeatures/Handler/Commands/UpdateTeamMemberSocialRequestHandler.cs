using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials.Validators;
using Application.features.GeneralInformations.TeamMemberSocialFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberSocialFeatures.Handler.Commands
{
    public class UpdateTeamMemberSocialRequestHandler : IRequestHandler<UpdateTeamMemberSocialRequest, ReturnData<TeamMemberSocialDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateTeamMemberSocialRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ReturnData<TeamMemberSocialDTO>> Handle(UpdateTeamMemberSocialRequest request, CancellationToken cancellationToken)
        {
            var teamMemberSocial = await _unitofWork.TeamMemberSocialRepository.GetEntityAsync(request.updateTeamMemberSocialDTO.Id);
            if (teamMemberSocial is null)
                return FillRetuenData<TeamMemberSocialDTO>.FillByEntity(
                    null,
                    ResponseStatus.NotFound,
                    null
                    );

            #region Validation
            var validator = new UpdateTeamMemberSocialDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.updateTeamMemberSocialDTO);
            if (!validatorResult.IsValid)
            {
                return FillRetuenData<TeamMemberSocialDTO>.FillByEntity(
                    null,
                    ResponseStatus.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList()
                    );
            }
            #endregion
            var toUpdate = _mapper.Map<TeamMemberSocial>(request.updateTeamMemberSocialDTO);
            _unitofWork.TeamMemberSocialRepository.UpdateEntityAsync(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<TeamMemberSocialDTO>.FillByEntity(
                                _mapper.Map<TeamMemberSocialDTO>(request.updateTeamMemberSocialDTO),
                                ResponseStatus.Success,
                                null);
        }
    }
}

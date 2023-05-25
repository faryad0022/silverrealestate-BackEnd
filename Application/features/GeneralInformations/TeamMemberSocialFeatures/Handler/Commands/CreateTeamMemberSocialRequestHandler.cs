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
    public class CreateTeamMemberSocialRequestHandler : IRequestHandler<CreateTeamMemberSocialRequest, ReturnData<TeamMemberSocialDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateTeamMemberSocialRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ReturnData<TeamMemberSocialDTO>> Handle(CreateTeamMemberSocialRequest request, CancellationToken cancellationToken)
        {
            var toCreate = _mapper.Map<TeamMemberSocial>(request.createTeamMemberSocialDTO);
            #region Validator
            var validator = new CreateTeamMemberSocialDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createTeamMemberSocialDTO);
            if (!validatorResult.IsValid)
            {
                return FillRetuenData<TeamMemberSocialDTO>.FillByEntity(
                    null,
                    ResponseStatus.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList()
                    );
            }
            #endregion
            var created = await _unitofWork.TeamMemberSocialRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<TeamMemberSocialDTO>.FillByEntity(
                _mapper.Map<TeamMemberSocialDTO>(created),
                ResponseStatus.Success,
                null
                );
        }
    }
}

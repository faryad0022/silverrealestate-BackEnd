using Application.Const.PathUtility;
using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers.Validators;
using Application.Extensions;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Commands
{
    public class UpdateTeamMemberRequestHandler : IRequestHandler<UpdateTeamMemberRequest, ReturnData<TeamMemberDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateTeamMemberRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<TeamMemberDTO>> Handle(UpdateTeamMemberRequest request, CancellationToken cancellationToken)
        {
            var teamMember = await _unitofWork.TeamMemberRepository.GetEntityAsync(request.updateTeamMemberDTO.Id);
            if (teamMember is null)
                return SetReturnData<TeamMemberDTO>.SetTEntity(
                    null,
                    ResponseStatus.NotFound,
                    null
                    );
            #region Upload Image
            if (request.updateTeamMemberDTO.MemberPicture != "")
            {
                var createdImageName = ImageUploaderExtensions.UploadImage(request.updateTeamMemberDTO.MemberPicture, PathTools.TeamServernPath, teamMember.MemberPicture);
                if (string.IsNullOrEmpty(createdImageName))
                    return SetReturnData<TeamMemberDTO>.SetTEntity(null, ResponseStatus.UploadError, null);
                request.updateTeamMemberDTO.MemberPicture = createdImageName;
            }
            else
            {
                request.updateTeamMemberDTO.MemberPicture = teamMember.MemberPicture;

            }

            #endregion
            #region Validation
            var validator = new UpdateTeamMemberValidator();
            var validatorResult = await validator.ValidateAsync(request.updateTeamMemberDTO);
            if (!validatorResult.IsValid)
            {
                return SetReturnData<TeamMemberDTO>.SetTEntity(null,ResponseStatus.ValidationError,validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            }
            #endregion
      
            var toUpdate = _mapper.Map<TeamMember>(request.updateTeamMemberDTO);
            _unitofWork.TeamMemberRepository.UpdateEntityAsync(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return SetReturnData<TeamMemberDTO>.SetTEntity(
                                _mapper.Map<TeamMemberDTO>(request.updateTeamMemberDTO),
                                ResponseStatus.Success,
                                null);
        }
    }
}

﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers.Validators;
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
    public class CreateTeamMemberRequestHandler : IRequestHandler<CreateTeamMemberRequest, ReturnData<TeamMemberDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateTeamMemberRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<TeamMemberDTO>> Handle(CreateTeamMemberRequest request, CancellationToken cancellationToken)
        {
            var toCreate = _mapper.Map<TeamMember>(request.createTeamMmeberDTO);
            #region Validator
            var validator = new CreateTeamMemberDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createTeamMmeberDTO);
            if (!validatorResult.IsValid)
            {
                return FillRetuenData<TeamMemberDTO>.FillByEntity(
                    null,
                    ResponseStatus.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList()
                    );
            }
            #endregion
            var created = await _unitofWork.TeamMemberRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<TeamMemberDTO>.FillByEntity(
                _mapper.Map<TeamMemberDTO>(created),
                ResponseStatus.Success,
                null
                );
        }
    }
}
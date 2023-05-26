using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Commands;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.TeamMembers;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.TeamMembers.Commands
{
    public class UpdateTeamMemberRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public UpdateTeamMemberRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateTeamMember_Valid()
        {
            var handler = new UpdateTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateTeamMemberRequest() { updateTeamMemberDTO = TeamMemberModelGenerator.UpdateTeamMemberDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldNotBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
            result.Tentity.CellPhone.ShouldBe("00905338355243");
            result.Tentity.ShouldBeOfType(typeof(TeamMemberDTO));
        }
        [Fact]
        public async Task UpdateTeamMember_ValidationError_InValid()
        {
            var handler = new UpdateTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateTeamMemberRequest() { updateTeamMemberDTO = TeamMemberModelGenerator.UpdateTeamMemberDTO_ValidationError_InValid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.ValidationError);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldNotBeNull();
            result.Tentities.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateTeamMember_Notfound_InValid()
        {
            var handler = new UpdateTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateTeamMemberRequest() { updateTeamMemberDTO = TeamMemberModelGenerator.UpdateTeamMemberDTO_NotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
        }
    }
}

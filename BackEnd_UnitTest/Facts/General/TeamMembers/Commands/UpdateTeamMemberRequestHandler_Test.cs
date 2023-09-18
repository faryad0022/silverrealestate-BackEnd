using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.General.TeamMembers;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.TeamMembers.Commands
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

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();

        }
        [Fact]
        public async Task UpdateTeamMember_ValidationError_InValid()
        {
            var handler = new UpdateTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateTeamMemberRequest() { updateTeamMemberDTO = TeamMemberModelGenerator.UpdateTeamMemberDTO_ValidationError_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);

            result.Errors.ShouldNotBeNull();

        }
        [Fact]
        public async Task UpdateTeamMember_Notfound_InValid()
        {
            var handler = new UpdateTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateTeamMemberRequest() { updateTeamMemberDTO = TeamMemberModelGenerator.UpdateTeamMemberDTO_NotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);

            result.Errors.ShouldBeNull();

        }
    }
}

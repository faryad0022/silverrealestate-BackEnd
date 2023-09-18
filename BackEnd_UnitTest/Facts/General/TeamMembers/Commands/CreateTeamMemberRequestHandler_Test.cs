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
    public class CreateTeamMemberRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public CreateTeamMemberRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreateTeamMember_Valid()
        {
            var handler = new CreateTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new CreateTeamMemberRequest() { createTeamMmeberDTO = TeamMemberModelGenerator.CreateTeamMmeberDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();

        }
        [Fact]
        public async Task CreateTeamMember_ValidationError_InValid()
        {
            var handler = new CreateTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new CreateTeamMemberRequest() { createTeamMmeberDTO = TeamMemberModelGenerator.CreateTeamMmeberDTO_ValidationError_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);

            result.Errors.ShouldNotBeNull();

        }
    }
}

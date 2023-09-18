using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.TeamMembers.Commands
{
    public class ChangeTeamMemberSelectedStatusRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public ChangeTeamMemberSelectedStatusRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task ChangeTeamMemberSelectedStatus_Valid()
        {
            var handler = new ChangeTeamMemberSelectedStatusRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new ChangeTeamMemberSelectedStatusRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();

        }
        [Fact]
        public async Task ChangeTeamMemberSelectedStatus_Valid_Notfound_InValid()
        {
            var handler = new ChangeTeamMemberSelectedStatusRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new ChangeTeamMemberSelectedStatusRequest() { Id = 11 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);

            result.Errors.ShouldBeNull();

        }
    }
}

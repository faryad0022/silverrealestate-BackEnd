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

namespace BackEnd_UnitTest.Facts.General.TeamMembers.Queries
{
    public class GetTeamMemberListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public GetTeamMemberListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetTeamMemberList_Valid()
        {
            var handler = new GetTeamMemberListRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetTeamMemberListRequest { justSelected = false }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetTeamMemberList_Selected_Valid()
        {
            var handler = new GetTeamMemberListRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new GetTeamMemberListRequest { justSelected = true }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();

        }
    }
}

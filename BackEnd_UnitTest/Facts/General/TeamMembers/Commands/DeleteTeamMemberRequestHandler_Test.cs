using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.TeamMemberFeatures.Hnadler.Commands;
using Application.features.GeneralInformations.TeamMemberFeatures.Request.Commands;
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
    public class DeleteAddressRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _unitOfWork;
        public DeleteAddressRequestHandler_Test()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task DeleteTeamMemberRequestHandler_Valid()
        {
            var handler = new RemoveTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new RemoveTeamMemberRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);


            result.Errors.ShouldBeNull();
        }

        [Fact]
        public async Task DeleteTeamMemberRequestHandler_NotFound_InValid()
        {
            var handler = new RemoveTeamMemberRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new RemoveTeamMemberRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);


            result.Errors.ShouldBeNull();
        }
    }
}

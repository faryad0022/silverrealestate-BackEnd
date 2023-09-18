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

namespace BackEnd_UnitTest.Facts.Projects.PropertyPlans.Commands
{
    public class DeletePropertyPlanRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public DeletePropertyPlanRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task DeletePropertyPlan_valid()
        {
            var handler = new DeletePropertyPlanRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeletePropertyPlanRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();

        }

        [Fact]
        public async Task DeletePropertyPlan_Notfound_Invalid()
        {
            var handler = new DeletePropertyPlanRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeletePropertyPlanRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();

        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyFeatures.Handler.Queries;
using Application.features.Projects.PropertyFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.Properties.Queries
{
    public class GetPropertyRequestWithDetailsHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public GetPropertyRequestWithDetailsHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetPropertyWithDetails_Valid()
        {
            var handler = new GetPropertyRequestWithDetailsHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyWithDetailsRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetProperty_NotFound_InValid()
        {
            var handler = new GetPropertyRequestWithDetailsHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyWithDetailsRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
    }
}

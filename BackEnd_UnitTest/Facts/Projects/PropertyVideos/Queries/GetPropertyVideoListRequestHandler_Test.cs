using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyVideFeatures.Handler.Queries;
using Application.features.Projects.PropertyVideFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyVideos.Queries
{
    public class GetPropertyVideoListRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public GetPropertyVideoListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetPropertyVideo_Valid()
        {
            var handler = new GetPropertyVideoListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyVideoListRequest() { PropertyId = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetPropertyVideoList_NotFound_InValid()
        {
            var handler = new GetPropertyVideoListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyVideoListRequest() { PropertyId = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NoContent);
            result.Errors.ShouldBeNull();


        }
    }
}

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
    public class GetPropertyListWithDetailsRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetPropertyListWithDetailsRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetPropertyListWithDetails_Valid()
        {
            var handler = new GetPropertyListWithDetailsRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyListWithDetailsRequest(), CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task Get_Selected_GetPropertyListWithDetails_Valid()
        {
            var handler = new GetPropertyListWithDetailsRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyListWithDetailsRequest() { Selected = true }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NoContent);
            result.Errors.ShouldBeNull();
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyTypeFeatures.Handler.Queries;
using Application.features.Projects.PropertyTypeFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyTypes.Queries
{
    public class GetPropertyTypeListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetPropertyTypeListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetPropertyTypeList_Valid()
        {
            var handler = new GetPropertyTypeListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyTypeListRequest(), CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task Get_Selected_GetPropertyTypeList_Valid()
        {
            var handler = new GetPropertyTypeListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyTypeListRequest() { justSelected = true }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyGalleryFeatures.Handler.Qureries;
using Application.features.Projects.PropertyGalleryFeatures.Request.Qureries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyGalleries.Queries
{
    public class GetPropertyGalleryListRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public GetPropertyGalleryListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetPropertyGallery_Valid()
        {
            var handler = new GetPropertyGalleryListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyGalleryListRequest() { PropertyId = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetPropertyGalleryList_NotFound_InValid()
        {
            var handler = new GetPropertyGalleryListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyGalleryListRequest() { PropertyId = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NoContent);
            result.Errors.ShouldBeNull();


        }
    }
}

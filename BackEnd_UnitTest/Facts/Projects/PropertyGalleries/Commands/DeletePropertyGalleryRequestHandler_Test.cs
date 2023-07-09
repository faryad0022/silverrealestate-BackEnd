using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyGalleryFeatures.Handler.Commands;
using Application.features.Projects.PropertyGalleryFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyGalleries.Commands
{
    public class DeletePropertyGalleryRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public DeletePropertyGalleryRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task DeletePropertyGallery_valid()
        {
            var handler = new DeletePropertyGalleryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeletePropertyGalleryRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();

        }

        [Fact]
        public async Task DeletePropertyGallery_Notfound_Invalid()
        {
            var handler = new DeletePropertyGalleryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeletePropertyGalleryRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();

        }
    }
}

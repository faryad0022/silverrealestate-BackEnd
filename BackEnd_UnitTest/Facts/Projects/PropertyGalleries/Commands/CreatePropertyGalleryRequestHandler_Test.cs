using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.Projects.PropertyGalleries;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyGalleries.Commands
{
    public class CreatePropertyGalleryRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public CreatePropertyGalleryRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreatePropertyGallery_valid()
        {
            var handler = new CreatePropertyGalleryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyGalleryRequest() { createPropertyGalleryDTO = PropertyGalleryModelGenerator._createPropertyGalleryDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();

        }
        [Fact]
        public async Task CreatePropertyGallery_ValidationError_Invalid()
        {
            var handler = new CreatePropertyGalleryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyGalleryRequest() { createPropertyGalleryDTO = PropertyGalleryModelGenerator._createPropertyGalleryDTO_ValidationError_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
        [Fact]
        public async Task CreatePropertyGallery_ValidationError_NotExist_Invalid()
        {
            var handler = new CreatePropertyGalleryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyGalleryRequest() { createPropertyGalleryDTO = PropertyGalleryModelGenerator._createPropertyGalleryDTO_ValidationError_NotExist_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
    }
}

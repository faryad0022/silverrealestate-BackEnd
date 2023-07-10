using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyVideFeatures.Handler.Commands;
using Application.features.Projects.PropertyVideFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.Projects.PropertyVideos;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyVideos.Commands
{
    public class CreatePropertyVideoRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public CreatePropertyVideoRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreatePropertyVideo_valid()
        {
            var handler = new CreatePropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyVideoRequest() { createPropertyVideoDTO = PropertyVideoModelGenerator._createPropertyVideoDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();

        }
        [Fact]
        public async Task CreatePropertyVideo_ValidationError_Invalid()
        {
            var handler = new CreatePropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyVideoRequest() { createPropertyVideoDTO = PropertyVideoModelGenerator._createPropertyVideoDTO_ValidationError_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
        [Fact]
        public async Task CreatePropertyVideo_ValidationError_NotExist_Invalid()
        {
            var handler = new CreatePropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreatePropertyVideoRequest() { createPropertyVideoDTO = PropertyVideoModelGenerator._createPropertyVideoDTO_ValidationError_NotExist_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
    }
}

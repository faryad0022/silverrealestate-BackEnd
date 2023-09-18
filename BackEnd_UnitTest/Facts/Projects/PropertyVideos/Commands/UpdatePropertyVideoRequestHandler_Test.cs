using Application.Const.Response;
using Application.Contract.Persistence;
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
    public class UpdatePropertyVideoRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdatePropertyVideoRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task UpdatePropertyVideoRequestHandler_Valid()
        {
            var handler = new UpdatePropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyVideoRequest() { updatePropertyVideoDTO = PropertyVideoModelGenerator._updatePropertyVideoDTO_Valid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task UpdatePropertyVideoRequestHandler_Validation_InValid()
        {
            var handler = new UpdatePropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyVideoRequest() { updatePropertyVideoDTO = PropertyVideoModelGenerator._updatePropertyVideoDTO_ValidationError_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
        [Fact]
        public async Task UpdatePropertyVideoRequestHandler_Validation_NotFound_InValid()
        {
            var handler = new UpdatePropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyVideoRequest() { updatePropertyVideoDTO = PropertyVideoModelGenerator._updatePropertyVideoDTO_ValidationError_PropertyNotFound_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
        [Fact]
        public async Task UpdatePropertyVideoRequestHandler_Validation_Video_NotFound_InValid()
        {
            var handler = new UpdatePropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdatePropertyVideoRequest() { updatePropertyVideoDTO = PropertyVideoModelGenerator._updatePropertyVideoDTO_ValidationError_PropertyVideoNotFound_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
    }
}

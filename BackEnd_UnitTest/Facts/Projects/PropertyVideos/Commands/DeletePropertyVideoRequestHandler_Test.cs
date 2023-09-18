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

namespace BackEnd_UnitTest.Facts.Projects.PropertyVideos.Commands
{
    public class DeletePropertyVideoRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public DeletePropertyVideoRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task DeletePropertyVideo_valid()
        {
            var handler = new DeletePropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeletePropertyVideoRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();

        }

        [Fact]
        public async Task DeletePropertyVideo_Notfound_Invalid()
        {
            var handler = new DeletePropertyVideoRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeletePropertyVideoRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();

        }
    }
}

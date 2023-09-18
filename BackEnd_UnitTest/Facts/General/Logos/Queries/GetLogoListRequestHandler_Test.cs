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

namespace BackEnd_UnitTest.Facts.General.Logos.Queries
{
    public class GetLogoListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepo;
        public GetLogoListRequestHandler_Test()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetLogoList_Valid()
        {
            var handler = new GetLogoListRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new GetLogoListRequest(), CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task GetSelectedLogoList_Valid()
        {
            var handler = new GetLogoListRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new GetLogoListRequest() { justShowSelected = true }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();


        }
    }

}

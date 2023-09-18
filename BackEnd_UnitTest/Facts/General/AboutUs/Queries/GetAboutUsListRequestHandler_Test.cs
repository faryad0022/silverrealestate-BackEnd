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

namespace BackEnd_UnitTest.Facts.General.AboutUs.Queries
{
    public class GetAboutUsListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepo;
        public GetAboutUsListRequestHandler_Test()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task Get_AboutUsList_Valid()
        {
            var handler = new GetAboutUsListRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new GetAboutUsListRequest(), CancellationToken.None);

            result.Errors.ShouldBeNull();


            result.Status.ShouldBe(StatusMessage.Success);

        }

        [Fact]
        public async Task Get_Selected_AboutUsList_Valid()
        {
            var handler = new GetAboutUsListRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new GetAboutUsListRequest() { justShowSelected = true }, CancellationToken.None);

            result.Errors.ShouldBeNull();

            result.Status.ShouldBe(StatusMessage.Success);

        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.AboutUsFeatures.Handler.Queries;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.AboutUs.Queries
{
    public class GetAboutUsRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepo;
        public GetAboutUsRequestHandler_Test()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task Get_AboutUs_Valid()
        {
            var handler = new GetAboutUsRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new GetAboutUsRequest() { Id = 1 }, CancellationToken.None);

            result.Errors.ShouldBeNull();
            
            
            result.Status.ShouldBe(StatusMessage.Success);
        }

        [Fact]
        public async Task Get_AboutUs_NotFound_InValid()
        {
            var handler = new GetAboutUsRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new GetAboutUsRequest() { Id = 10 }, CancellationToken.None);

            result.Errors.ShouldBeNull();
            
            
            result.Status.ShouldBe(StatusMessage.NotFound);
        }
    }
}

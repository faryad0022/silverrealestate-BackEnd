using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.BannerFeatures.Handler.Queries;
using Application.features.GeneralInformations.BannerFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Banners.Queries
{
    public class GetBannerRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetBannerRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetBanner_Valid()
        {
            var handler = new GetBannerRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBannerRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            
            result.Errors.ShouldBeNull();
            

        }
        [Fact]
        public async Task GetBanner_NotFound_InValid()
        {
            var handler = new GetBannerRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBannerRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            
            result.Errors.ShouldBeNull();
            

        }
    }
}

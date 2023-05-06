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
    public class GetBannerListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetBannerListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetBannerList_Valid()
        {
            var handler = new GetBannerListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBannerListRequest(), CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldNotBeNull();

        }
        [Fact]
        public async Task Get_Selected_BannerList_Valid()
        {
            var handler = new GetBannerListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBannerListRequest() { justShowSelected=true}, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldNotBeNull();
            result.Tentities.Count.ShouldBe(2);


        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.BannerFeatures.Handler.Commands;
using Application.features.GeneralInformations.BannerFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Banners.Commands
{
    public class ChangeBannerSelectedStatusRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public ChangeBannerSelectedStatusRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task ChangeBannerSelectedStatus_Valid()
        {
            var handler = new ChangeBannerSelectedStatusRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new ChangeBannerSelectedStatusRequest() { Id = 2 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldNotBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();

        }
        [Fact]
        public async Task ChangeBannerSelectedStatus_NotFound_InValid()
        {
            var handler = new ChangeBannerSelectedStatusRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new ChangeBannerSelectedStatusRequest() { Id = 7 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();

        }
    }
}

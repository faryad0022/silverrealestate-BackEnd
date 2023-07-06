using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.BannerFeatures.Handler.Commands;
using Application.features.GeneralInformations.BannerFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.Banners;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.Banners.Commands
{
    public class CreateBannerRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreateBannerRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreateBanner_Valid()
        {
            var handler = new CreateBannerRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateBannerRequest() { createBannerDTO = BannerModelGenerator.createBannerDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task CreateBanner_Validation_InValid()
        {
            var handler = new CreateBannerRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateBannerRequest() { createBannerDTO = BannerModelGenerator.createBannerDTO_Validation_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);

            result.Errors.ShouldNotBeNull();


        }
        [Fact]
        public async Task CreateBanner_UploadError_InValid()
        {
            var handler = new CreateBannerRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateBannerRequest() { createBannerDTO = BannerModelGenerator.createBannerDTO_UploadError_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.UploadError);

            result.Errors.ShouldBeNull();


        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.LogoFeatures.Handler.Commands;
using Application.features.GeneralInformations.LogoFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Logos.Commands
{
    public class ChangeLogoSelectStatusRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepo;
        public ChangeLogoSelectStatusRequestHandler_Test()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task ChangeLogoSelected_Valid()
        {
            var handler = new ChangeLogoSelectStatusRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new ChangeLogoSelectStatusRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task ChangeLogoSelected_NotFound_InValid()
        {
            var handler = new ChangeLogoSelectStatusRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new ChangeLogoSelectStatusRequest() { Id = 6 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
    }
}

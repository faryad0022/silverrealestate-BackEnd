using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.LogoFeatures.Handler.Commands;
using Application.features.GeneralInformations.LogoFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.Logos;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Logos.Commands
{
    public class CreateLogoRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepo;
        public CreateLogoRequestHandler_Test()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreateLogo_Valid()
        {
            var handler = new CreateLogoRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new CreateLogoRequest() { createLogoDTO = LogoModelGenerator.createDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
            
            
        }
        [Fact]
        public async Task CreateLogo_ValidationError_InValid()
        {
            var handler = new CreateLogoRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new CreateLogoRequest() { createLogoDTO = LogoModelGenerator.createDTO_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
            
            
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.General.About;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.AboutUs.Commands
{
    public class CreateAboutUsRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepo;
        public CreateAboutUsRequestHandler_Test()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task Create_Invalid_NotAllowed_AboutUs_Valid()
        {
            var handler = new CreateAboutUsRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new CreateAboutUsRequest() { createAboutUsDTO = AboutUsModelGenerator.createAboutUsDTO_Valid }, CancellationToken.None);

            result.Errors.ShouldBeNull();


            result.Status.ShouldBe(StatusMessage.NotAllow);

        }
        [Fact]
        public async Task Create_Invalid_Validation_AboutUs_Valid()
        {
            var handler = new CreateAboutUsRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new CreateAboutUsRequest() { createAboutUsDTO = AboutUsModelGenerator.createAboutUsDTO_Validation_InValid }, CancellationToken.None);

            result.Errors.ShouldNotBeNull();


            result.Status.ShouldBe(StatusMessage.ValidationError);
        }
    }
}

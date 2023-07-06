using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.SocialFeatures.Handler.Commands;
using Application.features.GeneralInformations.SocialFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.Socials;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.Socials.Commands
{
    public class CreateSocialRequestHandlerTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepository;
        public CreateSocialRequestHandlerTest()
        {
            _mockRepository = MockUniOfWork.GetMockUnitOfWork();
            var mappConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();

        }
        [Fact]
        public async Task Valid_CreateSocial()
        {
            var handler = new CreateSocialRequestHandler(_mockRepository.Object, _mapper);
            var result = await handler.Handle(new CreateSocialRequest() { createSocialDTO = SocialModelGenerator._createSocialDTO }, CancellationToken.None);

            result.ShouldBeOfType<ResponseResultDTO>();

            result.Errors.ShouldBeNull();
            result.Status.ShouldBe(StatusMessage.Success);
        }

        [Fact]
        public async Task InValid_CreateSocial_ValidationError()
        {
            SocialModelGenerator._createSocialDTO.Icon = "";
            var handler = new CreateSocialRequestHandler(_mockRepository.Object, _mapper);
            var result = await handler.Handle(new CreateSocialRequest() { createSocialDTO = SocialModelGenerator._createSocialDTO }, CancellationToken.None);

            result.ShouldBeOfType<ResponseResultDTO>();
            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeEmpty();
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.features.GeneralInformations.SocialFeatures.Handler.Queries;
using Application.features.GeneralInformations.SocialFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Socials.Queries
{
    public class GetSocialRequestHandlerTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockSocialRepository;
        public GetSocialRequestHandlerTest()
        {
            _mockSocialRepository = MockUniOfWork.GetMockUnitOfWork();
            var mapConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mapConfig.CreateMapper();
        }
        [Fact]
        public async Task Valid_GetSocial()
        {
            var handler = new GetSocialRequestHandler(_mapper, _mockSocialRepository.Object);
            var result = await handler.Handle(new GetSocialRequest() { Id = 2 }, CancellationToken.None);
            result.ShouldBeOfType<ResponseResult>();
            result.Status.ShouldBe(StatusMessage.Success);
        }
        [Fact]
        public async Task InvalidValid_GetSocial_Validationerror()
        {
            var handler = new GetSocialRequestHandler(_mapper, _mockSocialRepository.Object);
            var result = await handler.Handle(new GetSocialRequest() { Id = -2 }, CancellationToken.None);

            result.ShouldBeOfType<ResponseResult>();
            result.Status.ShouldBe(StatusMessage.ValidationError);
        }
        [Fact]
        public async Task InvalidValid_GetSocial_NotFound()
        {
            var handler = new GetSocialRequestHandler(_mapper, _mockSocialRepository.Object);
            var result = await handler.Handle(new GetSocialRequest() { Id = 3 }, CancellationToken.None);
            result.ShouldBeOfType<ResponseResult>();
            result.Status.ShouldBe(StatusMessage.NotFound);
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
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
    public class GetSocialListRequestHandlerTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepository;
        public GetSocialListRequestHandlerTest()
        {
            _mockRepository = MockUniOfWork.GetMockUnitOfWork();
            var mappConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();

        }
        [Fact]
        public async Task GetSocialList()
        {
            var handler = new GetSocialListRequestHandler(_mapper, _mockRepository.Object);
            var result = await handler.Handle(new GetSocialListRequest(), CancellationToken.None);


            result.ShouldBeOfType<ResponseResultDTO>();
            result.Status.ShouldBe(StatusMessage.Success);

        }
        [Fact]
        public async Task GetSelectedSocialList()
        {
            var handler = new GetSocialListRequestHandler(_mapper, _mockRepository.Object);
            var result = await handler.Handle(new GetSocialListRequest() { justShowSelected = true }, CancellationToken.None);


            result.ShouldBeOfType<ResponseResultDTO>();
            result.Status.ShouldBe(StatusMessage.Success);

        }

    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Blog.Handler.Queries.BlogGroup;
using Application.features.Blog.Request.Queries.BlogGroup;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.BlogGroups.Queries
{
    public class GetBlogGroupListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepo;
        public GetBlogGroupListRequestHandler_Test()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task Valid_GetBlogGroupList()
        {
            var handler = new GetBlogGroupListRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new GetBlogGroupListRequest(), CancellationToken.None);

            result.ShouldBeOfType<ResponseResultDTO>();
            result.Status.ShouldBe(StatusMessage.Success);

        }

    }
}

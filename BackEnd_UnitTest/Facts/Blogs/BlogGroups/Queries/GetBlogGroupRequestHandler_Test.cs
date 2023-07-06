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

namespace BackEnd_UnitTest.Facts.Blogs.BlogGroups.Queries
{
    public class GetBlogGroupRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetBlogGroupRequestHandler_Test()
        {
            var mapperConf = new MapperConfiguration(cofg =>
            {
                cofg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConf.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();

        }
        [Fact]
        public async Task Valid_GetBlogGroupTest()
        {
            var handler = new GetBlogGroupRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBlogGroupRequest() { blogGroupId = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
        }
        [Fact]
        public async Task InValid_GetBlogGroupTest()
        {
            var handler = new GetBlogGroupRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBlogGroupRequest() { blogGroupId = 7 }, CancellationToken.None);



            result.Errors.ShouldBeNull();
            result.Status.ShouldBe(StatusMessage.NotFound);
        }
    }
}

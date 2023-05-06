using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Blog.Handler.Queries.BlogContent;
using Application.features.Blog.Request.Queries.BlogContent;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.BlogContents.Queries
{
    public class GetBlogContentWithDetailsHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetBlogContentWithDetailsHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetBlogContentWithDetails_Valid()
        {
            var handler = new GetBlogContentWithDetailsHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBlogContentWithDetails() { blogContentId = 3 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
            result.Tentity.BlogGroupId.ShouldBe(3);
        }

        [Fact]
        public async Task GetBlogContentWithDetails_NotExist_BlogContent_InValid()
        {
            var handler = new GetBlogContentWithDetailsHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBlogContentWithDetails() { blogContentId = 37 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
            result.Tentity.ShouldBeNull();
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Blog.Handler.Queries.BlogContent;
using Application.features.Blog.Request.Queries.BlogContent;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.BlogContents;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Blogs.BlogContents.Queries
{
    public class GetBlogContentByFilterRequest_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetBlogContentByFilterRequest_Test()
        {
            _mock = MockUniOfWork.GetMockUnitOfWork();
            var mappingConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mappingConfig.CreateMapper();
        }
        [Fact]
        public async Task GetBlogcontentFilter_ByTitle_ByFilledBlogContentList_Valid()
        {
            var handler = new GetBlogContentByFilterRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBlogContentByFilterRequest() { filter = BlogContentModelGenerator.filterBlogContent_ByTitle_blogList_Valid }, CancellationToken.None);



            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task GetBlogcontentByFilter_ById_Valid()
        {
            var handler = new GetBlogContentByFilterRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBlogContentByFilterRequest() { filter = BlogContentModelGenerator.filterBlogContent_ById_Valid }, CancellationToken.None);



            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();


        }
    }
}

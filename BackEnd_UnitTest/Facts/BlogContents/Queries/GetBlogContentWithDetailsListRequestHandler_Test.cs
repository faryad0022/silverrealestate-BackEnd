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
    public class GetBlogContentWithDetailsListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetBlogContentWithDetailsListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetBlogContentWithDetailsListRequestHandler_Valid()
        {
            var handler = new GetBlogContentWithDetailsListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetBlogContentWithDetailsListRequest(), CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Errors.ShouldBeNull();
            result.Tentities.Count.ShouldBe(6);
            result.Tentity.ShouldBeNull();


        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Blog.Handler.Commands.BlogcontentCommands;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.BlogContents;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Blogs.BlogContents.Commands
{
    public class UpdateBlogcontentRequestHandler_Test
    {
        private readonly Mock<IUnitofWork> _mockRepo;
        private readonly IMapper _mapper;
        public UpdateBlogcontentRequestHandler_Test()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateBlogContent_Valid()
        {
            var handler = new UpdateBlogcontentRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new UpdateBlogcontentRequest()
            {
                Id = 1,
                updateBlogContentDTO = BlogContentModelGenerator._updateBlogContentDTO_Valid
            }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateBlogContent_InValid()
        {
            var handler = new UpdateBlogcontentRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new UpdateBlogcontentRequest()
            {
                Id = 37,
                updateBlogContentDTO = BlogContentModelGenerator._updateBlogContentDTO_Valid
            }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);

            result.Errors.ShouldBeNull();
        }

        [Fact]
        public async Task ChangeBlogContentStatus_Valid()
        {
            var handler = new UpdateBlogcontentRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new UpdateBlogcontentRequest()
            {
                Id = 1,
                changeBlogContentStatusDTO = BlogContentModelGenerator.changeBlogContentStatusDTO_Valid
            }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();

        }

        [Fact]
        public async Task ChangeBlogContentIsSelected_Valid()
        {
            var handler = new UpdateBlogcontentRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new UpdateBlogcontentRequest()
            {
                Id = 1,
                changeBlogContentIsSelected = BlogContentModelGenerator.changeBlogContentIsSelectedDTO_Valid
            }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();

        }
    }
}

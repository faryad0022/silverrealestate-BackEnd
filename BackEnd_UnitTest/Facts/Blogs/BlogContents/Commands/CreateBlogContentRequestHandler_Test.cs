using Application.Const.Response;
using Application.Contract.Infrastructure;
using Application.Contract.Persistence;
using Application.features.Blog.Handler.Commands.BlogcontentCommands;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using Application.Models;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.Blogs.BlogContents;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Blogs.BlogContents.Commands
{
    public class CreateBlogContentRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IEmailSender> _mockEmail;
        private readonly Mock<IUnitofWork> _mockUOW;
        public CreateBlogContentRequestHandler_Test()
        {

            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mockUOW = MockUniOfWork.GetMockUnitOfWork();
            _mockEmail = new Mock<IEmailSender>();
            _mockEmail.Setup(m => m.SendEmailAsync(It.IsAny<Email>())).ReturnsAsync(true);
        }
        [Fact]
        public async Task Create_BlogContent_Valid()
        {
            var handler = new CreateBlogContentRequestHandler(_mapper, _mockEmail.Object, _mockUOW.Object);
            var result = await handler.Handle(new CreateBlogContentRequest() { createBlogContentDTO = BlogContentModelGenerator._createBlogContentDTO_Valid }, CancellationToken.None);



            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();


        }

        [Fact]
        public async Task Create_BlogContent_EmptyBlogGroupId_InValid()
        {
            var handler = new CreateBlogContentRequestHandler(_mapper, _mockEmail.Object, _mockUOW.Object);
            var result = await handler.Handle(new CreateBlogContentRequest() { createBlogContentDTO = BlogContentModelGenerator._createBlogContentDTO_EmptyBlogGroupId_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }

        [Fact]
        public async Task Create_BlogContent_NotExistBlogGroup_InValid()
        {
            var handler = new CreateBlogContentRequestHandler(_mapper, _mockEmail.Object, _mockUOW.Object);
            var result = await handler.Handle(new CreateBlogContentRequest() { createBlogContentDTO = BlogContentModelGenerator._createBlogContentDTO_NotExistBlogGroup_InValid }, CancellationToken.None);



            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
    }
}

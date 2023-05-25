using Application.Const.Response;
using Application.Contract.Infrastructure;
using Application.Contract.Persistence;
using Application.features.Blog.Handler.Commands.BlogGroupCommands;
using Application.features.Blog.Request.Commands.BlogGroupCommands;
using Application.Models;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.BlogGroups;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.BlogGroups.Commands
{
    public class CreateBlogGroupRequestCommandHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        private readonly Mock<IEmailSender> _mockEmailSender;

        public CreateBlogGroupRequestCommandHandler_Test()
        {
            _mock = MockUniOfWork.GetMockUnitOfWork();
            _mockEmailSender = new Mock<IEmailSender>();
            _mockEmailSender.Setup(m => m.SendEmailAsync(It.IsAny<Email>())).ReturnsAsync(() => true);
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();


        }
        [Fact]
        public async Task AddBlogGroup_Valid()
        {
            var handler = new CreateBlogGroupRequestCommandHandler(_mockEmailSender.Object, _mock.Object, _mapper);
            var result = await handler.Handle(new CreateBlogGroupRequestCommand() { createBlogGroupDTO = BlogGroupModelGenerator._createBlogGroupDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Errors.ShouldBeNull();
            result.Tentity.Name.ShouldBe("News 6");
            result.Tentities.ShouldBeNull();
        }

        [Fact]
        public async Task AddBlogGroup_InValid()
        {
            var handler = new CreateBlogGroupRequestCommandHandler(_mockEmailSender.Object, _mock.Object, _mapper);
            var result = await handler.Handle(new CreateBlogGroupRequestCommand() { createBlogGroupDTO = BlogGroupModelGenerator._createBlogGroupDTO_InValid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.ValidationError);
            result.Errors.ShouldNotBeNull();
            result.Tentity.ShouldBeNull();
            result.Tentities.ShouldBeNull();
        }
    }
}

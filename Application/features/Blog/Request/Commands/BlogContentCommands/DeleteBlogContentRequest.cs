using Application.Const.Response;
using Application.DTOs.Blog.BlogContent;
using MediatR;

namespace Application.features.Blog.Request.Commands.BlogContentCommands
{
    public class DeleteBlogContentRequest : IRequest<ResponseResultDTO>
    {
        public BlogContentDTO blogContentDTO { get; set; }
    }
}

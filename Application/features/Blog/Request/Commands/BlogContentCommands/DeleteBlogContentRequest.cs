using Application.DTOs.Blog.BlogContent;
using Application.Reaspose;
using MediatR;

namespace Application.features.Blog.Request.Commands.BlogContentCommands
{
    public class DeleteBlogContentRequest : IRequest<ReturnData<BlogContentDTO>>
    {
        public BlogContentDTO blogContentDTO { get; set; }
    }
}

using Application.DTOs.Blog.BlogContent;
using Application.Reaspose;
using MediatR;


namespace Application.features.Blog.Request.Commands.BlogContentCommands
{
    public class CreateBlogContentRequest : IRequest<ReturnData<CreateBlogContentDTO>>
    {
        public CreateBlogContentDTO createBlogContentDTO { get; set; }
    }
}

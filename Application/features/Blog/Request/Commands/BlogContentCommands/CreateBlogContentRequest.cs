using Application.Const.Response;
using Application.DTOs.Blog.BlogContent;
using MediatR;


namespace Application.features.Blog.Request.Commands.BlogContentCommands
{
    public class CreateBlogContentRequest : IRequest<ResponseResultDTO>
    {
        public CreateBlogContentDTO createBlogContentDTO { get; set; }
    }
}

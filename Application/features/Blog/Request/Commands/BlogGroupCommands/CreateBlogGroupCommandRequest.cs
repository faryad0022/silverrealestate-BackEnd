using Application.Const.Response;
using Application.DTOs.Blog.BlogGroup;
using MediatR;

namespace Application.features.Blog.Request.Commands.BlogGroupCommands
{
    public class CreateBlogGroupRequestCommand : IRequest<ResponseResultDTO>
    {
        public CreateBlogGroupDTO createBlogGroupDTO { get; set; }
    }
}

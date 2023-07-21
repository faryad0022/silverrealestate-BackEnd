using Application.Const.Response;
using Application.DTOs.Blog.BlogGroup;
using MediatR;

namespace Application.features.Blog.Request.Commands.BlogGroupCommands
{
    public class UpdateBlogGroupRequest : IRequest<ResponseResultDTO>
    {
        public UpdateBlogGroupDTO updateBlogGroupDTO { get; set; }
    }
}

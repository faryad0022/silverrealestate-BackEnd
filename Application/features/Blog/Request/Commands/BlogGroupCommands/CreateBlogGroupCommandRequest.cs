using Application.DTOs.Blog.BlogGroup;
using Application.Reaspose;
using MediatR;

namespace Application.features.Blog.Request.Commands.BlogGroupCommands
{
    public class CreateBlogGroupRequestCommand : IRequest<ReturnData<CreateBlogGroupDTO>>
    {
        public CreateBlogGroupDTO createBlogGroupDTO { get; set; }
    }
}

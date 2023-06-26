using Application.Const.Response;
using Application.DTOs.Blog.BlogContent;
using MediatR;

namespace Application.features.Blog.Request.Commands.BlogContentCommands
{
    public class UpdateBlogcontentRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
        public ChangeBlogContentIsSelectedDTO changeBlogContentIsSelected { get; set; }
        public ChangeBlogContentStatusDTO changeBlogContentStatusDTO { get; set; }
        public UpdateBlogContentDTO updateBlogContentDTO { get; set; }
    }
}

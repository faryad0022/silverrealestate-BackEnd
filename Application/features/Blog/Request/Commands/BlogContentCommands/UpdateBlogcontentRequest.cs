using Application.DTOs.Blog.BlogContent;
using Application.Reaspose;
using MediatR;

namespace Application.features.Blog.Request.Commands.BlogContentCommands
{
    public class UpdateBlogcontentRequest : IRequest<ReturnData<UpdateBlogContentDTO>>
    {
        public long Id { get; set; }
        public ChangeBlogContentIsSelectedDTO changeBlogContentIsSelected { get; set; }
        public ChangeBlogContentStatusDTO changeBlogContentStatusDTO { get; set; }
        public UpdateBlogContentDTO updateBlogContentDTO { get; set; }
    }
}

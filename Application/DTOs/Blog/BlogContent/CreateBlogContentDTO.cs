using Application.DTOs.Blog.BlogContent.Common;

namespace Application.DTOs.Blog.BlogContent
{
    public class CreateBlogContentDTO : IBlogcontentDTO
    {
        #region Properties

        public string Title { get; set; }
        public string Tags { get; set; }
        public string ImageName { get; set; }
        public string Text { get; set; }
        public long BlogGroupId { get; set; }

        #endregion

    }
}

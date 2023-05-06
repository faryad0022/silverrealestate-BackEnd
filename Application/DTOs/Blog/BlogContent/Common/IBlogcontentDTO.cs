namespace Application.DTOs.Blog.BlogContent.Common
{
    public interface IBlogcontentDTO
    {
        public string Title { get; set; }
        public string Tags { get; set; }
        public string ImageName { get; set; }
        public string Text { get; set; }
        public long BlogGroupId { get; set; }
    }
}

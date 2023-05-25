namespace Domain.Entities.Blog
{
    public class BlogContent : BaseEntity
    {
        #region Properties
        public string BlogGroupName { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string ImageName { get; set; }
        public string Review { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; } = false;
        public long ViewCount { get; set; } = 0;
        #endregion
        #region Foreign Key
        public long BlogGroupId { get; set; }

        #endregion
        #region Relations
        public BlogGroup blogGroup { get; set; }
        #endregion
    }
}

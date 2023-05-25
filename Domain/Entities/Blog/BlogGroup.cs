
using System.Collections.Generic;

namespace Domain.Entities.Blog
{
    public class BlogGroup : BaseEntity
    {
        #region Properties
        public string Name { get; set; }
        #endregion
        #region Relations
        public ICollection<BlogContent> BlogContents { get; set; }
        #endregion

    }
}

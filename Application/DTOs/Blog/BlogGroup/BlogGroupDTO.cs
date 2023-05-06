using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Blog.BlogGroup.Common;
using Application.DTOs.Common;
using System.Collections.Generic;

namespace Application.DTOs.Blog.BlogGroup
{
    public class BlogGroupDTO : BaseEntityDTO, IBlogGroupDTO    
    {
        #region Properties
        public string Name { get; set; }
        #endregion
        #region Relations
        public ICollection<BlogContentDTO> Blogs { get; set; }
        #endregion
    }
}

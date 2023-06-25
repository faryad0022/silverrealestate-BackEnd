using Application.Contract.Persistence.CommonGenericRepository;
using Application.DTOs.Blog.BlogContent;
using Application.Models.FilterModels;
using Domain.Entities.Blog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contract.Persistance.EntitiesRepository.Blog
{
    public interface IBlogContentRepository : IGenericRepository<BlogContent>
    {
        Task<List<BlogContent>> GetBlogContentWithDetailsListAsync();
        Task<BlogContent> GetBlogContentWithDetailsAsync(long BlogcontentId);
        Task ChangeBlogContentStatus(BlogContent blogContent);
        Task ChangeBlogContentIsSelected(BlogContent blogContent);
        Task<FilterBlogContent> FilterBlogContent(FilterBlogContent filter);
    }
}

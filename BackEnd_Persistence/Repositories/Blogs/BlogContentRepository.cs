using Application.Contract.Persistance.EntitiesRepository.Blog;
using Application.DTOs.Paging;
using Application.Extensions;
using Application.Models.FilterModels;
using Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Persistence.Repositories.Blogs
{
    public class BlogContentRepository : GenericRepository<BlogContent>, IBlogContentRepository
    {
        private readonly RealEstateDbContext _dbContext;

        public BlogContentRepository(RealEstateDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task ChangeBlogContentIsSelected(BlogContent blogContent)
        {
            blogContent.IsSelected = !blogContent.IsSelected;
            blogContent.LastUpdateDate = DateTime.Now;
        }

        public async Task ChangeBlogContentStatus(BlogContent blogContent)
        {
            blogContent.Status = !blogContent.Status;
            blogContent.LastUpdateDate = DateTime.Now;
        }

        public async Task<FilterBlogContent> FilterBlogContent(FilterBlogContent filter)
        {
            var blogContentQuery = GetEntitiesQuery().Include(x => x.blogGroup).AsQueryable();
            if (!string.IsNullOrEmpty(filter.Title))
            {
                blogContentQuery = blogContentQuery.Where(x => x.Title.Contains(filter.Title));

            }
            if (filter.BlogGroupId > 0)
            {
                blogContentQuery = blogContentQuery.Where(x => x.BlogGroupId == filter.BlogGroupId);
            }
            if (!string.IsNullOrEmpty(filter.BlogGroupName))
            {
                blogContentQuery = blogContentQuery.Where(x => x.blogGroup.Name.Contains(filter.BlogGroupName));
            }
            if (filter.ViewCount > 0)
            {
                blogContentQuery = blogContentQuery.Where(x => x.ViewCount == filter.ViewCount);
            }
            blogContentQuery = blogContentQuery.Where(x => x.IsDelete == filter.IsDelete);
            blogContentQuery = blogContentQuery.Where(x => x.IsSelected == filter.IsSelected);

            var count = (int)Math.Ceiling(blogContentQuery.Count() / (double)filter.TakeEntity);
            var pager = Pager.Build(count, filter.PageId, filter.TakeEntity);
            var bloContents = await blogContentQuery.Paging(pager).ToListAsync();
            return filter.SetPaging(pager).SetBlogContents(bloContents);
        }

        public async Task<BlogContent> GetBlogContentWithDetailsAsync(long BlogcontentId)
        {
            var blogContent = await _dbContext.BlogContents
                .Include(q => q.blogGroup)
                .SingleOrDefaultAsync(q => q.Id == BlogcontentId);
            return blogContent;
        }

        public async Task<List<BlogContent>> GetBlogContentWithDetailsListAsync()
        {
            var blogContents = await _dbContext.BlogContents.Include(q => q.blogGroup).ToListAsync();
            return blogContents;
        }

    }
}

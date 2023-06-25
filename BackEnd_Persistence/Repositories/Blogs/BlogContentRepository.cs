using Application.Contract.Persistance.EntitiesRepository.Blog;
using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Filters;
using Application.Filters;
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

        public async Task<FilterBlogContent> FilterBlogContent(FilterBlogContentDTO filter)
        {
            //var blogContentList = new List<BlogContent>();
            var result = new FilterBlogContent()
            {
                BlogGroupId = filter.BlogGroupId,
                BlogGroupName = filter.BlogGroupName,
                IsSelected = filter.IsSelected,
                Review = filter.Review,
                Status = filter.Status,
                Title = filter.Title,
                ViewCount = filter.ViewCount
            };

            if (filter.BlogContentList is null || filter.BlogContentList.Count < 1)
            {
                result.BlogContentList = await GetEntitiesQuery().Include(s => s.blogGroup).ToListAsync();
            }
            else
            {
                result.BlogContentList = MappingBlogContent(filter.BlogContentList);
            }
            if (!string.IsNullOrEmpty(filter.Title))
            {
                result.BlogContentList = result.BlogContentList
                                           .Where(x => x.Title.Contains(filter.Title))
                                           .AsQueryable()
                                           .ToList();
            }
            if (filter.BlogGroupId > 0)
            {
                result.BlogContentList = result.BlogContentList
                                           .Where(x => x.BlogGroupId == filter.BlogGroupId)
                                           .AsQueryable()
                                           .ToList();
            }
            if (!string.IsNullOrEmpty(filter.BlogGroupName))
            {
                result.BlogContentList = result.BlogContentList
                                           .Where(x => x.blogGroup.Name == filter.BlogGroupName)
                                           .AsQueryable()
                                           .ToList();
            }
            if (filter.ViewCount > 0)
            {
                result.BlogContentList = result.BlogContentList
                                           .Where(x => x.ViewCount == filter.ViewCount)
                                           .AsQueryable()
                                           .ToList();
            }
            return result;
        }

        public async Task<BlogContent> GetBlogContentWithDetailsAsync(long BlogcontentId)
        {
            var blogContent = await _dbContext.BlogContents
                .Include(q => q.blogGroup)
                .FirstOrDefaultAsync(q => q.Id == BlogcontentId);
            return blogContent;
        }

        public async Task<List<BlogContent>> GetBlogContentWithDetailsListAsync()
        {
            var blogContents = await _dbContext.BlogContents.Include(q => q.blogGroup).ToListAsync();
            return blogContents;
        }

        public List<BlogContent> MappingBlogContent(List<BlogContentDTO> blogContents)
        {
            var blogContentList = new List<BlogContent>();
            foreach (var item in blogContents)
            {
                var blogContent = new BlogContent
                {
                    Id = item.Id,
                    Status = item.Status,
                    BlogGroupId = item.BlogGroupId,
                    BlogGroupName = item.BlogGroupName,
                    IsSelected = item.IsSelected,
                    Tags = item.Tags,
                    ImageName = item.ImageName,
                    Text = item.Text,
                    Title = item.Title,
                    ViewCount = item.ViewCount,
                };
                blogContentList.Add(blogContent);
            }
            return blogContentList;
        }
    }
}

using Application.Contract.Persistance.EntitiesRepository.Blog;
using Application.DTOs.Blog.BlogContent;
using Application.Models.FilterModels;
using BackEnd_UnitTest.Mocks.Models.BlogContents;
using Domain.Entities.Blog;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd_UnitTest.Mocks
{
    public static class MockBlogContentRepository
    {

        public static Mock<IBlogContentRepository> GetBlogContentRepository()
        {
            var _mock = new Mock<IBlogContentRepository>();

            _mock.Setup(m => m.GetBlogContentWithDetailsAsync(It.IsAny<long>())).ReturnsAsync((long id)
                => BlogContentModelGenerator.blogContentList.FirstOrDefault(x => x.Id == id));

            _mock.Setup(m => m.GetBlogContentWithDetailsListAsync())
                .ReturnsAsync(() => BlogContentModelGenerator.blogContentList);
            _mock.Setup(m => m.GetAllAsync())
                .ReturnsAsync(BlogContentModelGenerator.blogContentList);
            _mock.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long Id) =>
            {
                var blogcontent = BlogContentModelGenerator.blogContentList.FirstOrDefault(x => x.Id == Id);
                return blogcontent != null;
            });

            _mock.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long Id) => BlogContentModelGenerator.blogContentList.FirstOrDefault(x => x.Id == Id));

            _mock.Setup(m => m.GetEntitiesQuery())
                .Returns(() => BlogContentModelGenerator.blogContentList.AsQueryable());

            _mock.Setup(m => m.FilterBlogContent(It.IsAny<FilterBlogContentDTO>()))
                .ReturnsAsync((FilterBlogContentDTO filter) =>
            {
                var blogContentList = new List<BlogContent>();
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
                    result.BlogContentList = BlogContentModelGenerator.blogContentList;
                }
                else
                {
                    result.BlogContentList = BlogContentModelGenerator.MappingBlogContent(BlogContentModelGenerator.blogContentListDTO);
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
                                               .Where(x => x.BlogGroupName == filter.BlogGroupName)
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
            });

            _mock.Setup(m => m.AddEntityAsync(It.IsAny<BlogContent>()))
                .ReturnsAsync((BlogContent blogContent) =>
            {
                BlogContentModelGenerator.blogContentList.Add(blogContent);
                return blogContent;
            });

            _mock.Setup(m => m.ChangeBlogContentStatus(It.IsAny<BlogContent>())).Callback((BlogContent blogContent) =>
            {
                blogContent.Status = !blogContent.Status;
                blogContent.LastUpdateDate = DateTime.Now;
            });
            _mock.Setup(m => m.ChangeBlogContentIsSelected(It.IsAny<BlogContent>())).Callback((BlogContent blogContent) =>
            {
                blogContent.IsSelected = !blogContent.IsSelected;
                blogContent.LastUpdateDate = DateTime.Now;
            });
            return _mock;
        }
    }
}

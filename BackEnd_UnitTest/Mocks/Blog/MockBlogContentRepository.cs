using Application.Contract.Persistance.EntitiesRepository.Blog;
using Application.Models.FilterModels;
using BackEnd_UnitTest.Mocks.Models.BlogContents;
using Domain.Entities.Blog;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.Blog
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

            _mock.Setup(m => m.FilterBlogContent(It.IsAny<FilterBlogContent>()))
                .ReturnsAsync((FilterBlogContent filter) =>
            {
                var blogContentList = new List<BlogContent>();

                if (!string.IsNullOrEmpty(filter.Title))
                {
                    blogContentList = blogContentList.Where(x => x.Title.Contains(filter.Title)).ToList();

                }
                if (filter.BlogGroupId > 0)
                {
                    blogContentList = blogContentList.Where(x => x.BlogGroupId == filter.BlogGroupId).ToList();
                }
                if (!string.IsNullOrEmpty(filter.BlogGroupName))
                {
                    blogContentList = blogContentList.Where(x => x.blogGroup.Name.Contains(filter.BlogGroupName)).ToList();
                }
                if (filter.ViewCount > 0)
                {
                    blogContentList = blogContentList.Where(x => x.ViewCount == filter.ViewCount).ToList();
                }
                blogContentList = blogContentList.Where(x => x.IsDelete == filter.IsDelete).ToList();
                blogContentList = blogContentList.Where(x => x.IsSelected == filter.IsSelected).ToList();

                //var count = (int)Math.Ceiling(blogContentList.Count() / (double)filter.TakeEntity);
                //var pager = Pager.Build(count, filter.PageId, filter.TakeEntity);
                //var bloContents = await blogContentList.Paging(pager).ToListAsync();
                //return filter.SetPaging(pager).SetBlogContents(bloContents);
                return filter;
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

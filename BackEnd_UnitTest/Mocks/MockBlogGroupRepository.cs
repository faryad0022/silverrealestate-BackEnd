using Application.Contract.Persistance.EntitiesRepository.Blog;
using BackEnd_UnitTest.Mocks.Models.BlogGroups;
using Domain.Entities.Blog;
using Moq;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_UnitTest.Mocks
{
    public static class MockBlogGroupRepository
    {
        public static Mock<IBlogGroupRepository> GetBlogGroupRepository_Mock()
        {
            var mockRepo = new Mock<IBlogGroupRepository>();

            mockRepo.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var blogGroup =  BlogGroupModelGenerator.blogGroupList.FirstOrDefault(x => x.Id == id);
                return blogGroup!=null;
            });

            mockRepo.Setup(m => m.GetAllAsync())
                .ReturnsAsync(BlogGroupModelGenerator.blogGroupList);


            mockRepo.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long Id) => BlogGroupModelGenerator.blogGroupList.FirstOrDefault(b => b.Id == Id));


            mockRepo.Setup(m => m.AddEntityAsync(It.IsAny<BlogGroup>()))
                .ReturnsAsync((BlogGroup blogGroup) =>
                {
                    BlogGroupModelGenerator.blogGroupList.Add(blogGroup);
                    return blogGroup;
                });

            mockRepo.Setup(m => m.DeleteEntityAsync(It.IsAny<BlogGroup>()))
                .Callback((BlogGroup blogGroup) =>
                {
                    BlogGroupModelGenerator.blogGroupList.Remove(blogGroup);
                });
            mockRepo.Setup(m => m.UpdateEntityAsync(It.IsAny<BlogGroup>())).Callback(() => { return; });
            mockRepo.Setup(m => m.IsDuplicate(It.IsAny<string>())).ReturnsAsync((string name) =>
            {
                var blogGroup = BlogGroupModelGenerator.blogGroupList.FirstOrDefault(m => m.Name == name);
                if (blogGroup == null) return false;
                return true;
            });
            return mockRepo;
        }
    }
}

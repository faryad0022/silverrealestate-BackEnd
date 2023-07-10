using Application.Contract.Persistance.EntitiesRepository.Project;
using BackEnd_UnitTest.Models.Projects.PropertyVideos;
using Domain.Entities.Project;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.Projects
{
    public class MockPropertyVideoRepository
    {
        public static Mock<IPropertyVideoRepository> GetPropertyVideoRepository()
        {
            var _mockRepo = new Mock<IPropertyVideoRepository>();
            var videoList = PropertyVideoModelGenerator.propertyVideolList;

            _mockRepo.Setup(m => m.GetEntityAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                return videoList.SingleOrDefault(c => c.Id == id);
            });
            _mockRepo.Setup(m => m.GetListVideoOfProperty(It.IsAny<long>()))
                .ReturnsAsync((long propertyId) =>
                {
                    return videoList.Where(c => c.PropertyId == propertyId).ToList();
                });
            _mockRepo.Setup(m => m.AddEntityAsync(It.IsAny<PropertyVideo>()))
                .ReturnsAsync((PropertyVideo video) =>
                {
                    videoList.Add(video);
                    return video;
                });
            _mockRepo.Setup(m => m.UpdateEntity(It.IsAny<PropertyVideo>())).Callback(() => { return; });
            _mockRepo.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var video = videoList.Find(x => x.Id == id);
                return !(video == null);
            });
            return _mockRepo;
        }

    }
}

using Application.Contract.Persistance.EntitiesRepository.Project;
using BackEnd_UnitTest.Models.Projects.PropertyGalleries;
using Domain.Entities.Project;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.Projects
{
    public static class MockPropertyGalleryRepository
    {
        public static Mock<IPropertyGalleryRepository> GetPropertyGalleryRepository()
        {
            var _mockRepo = new Mock<IPropertyGalleryRepository>();
            var galleryList = PropertyGalleryModelGenerator.propertyGallerylList;

            _mockRepo.Setup(m => m.GetEntityAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                return galleryList.SingleOrDefault(c => c.Id == id);
            });
            _mockRepo.Setup(m => m.GetPropertyGalleryList(It.IsAny<long>()))
                .ReturnsAsync((long propertyId) =>
                {
                    return galleryList.Where(c => c.PropertyId == propertyId).ToList();
                });
            _mockRepo.Setup(m => m.AddEntityAsync(It.IsAny<PropertyGallery>()))
                .ReturnsAsync((PropertyGallery city) =>
                {
                    galleryList.Add(city);
                    return city;
                });
            _mockRepo.Setup(m => m.UpdateEntity(It.IsAny<PropertyGallery>())).Callback(() => { return; });
            _mockRepo.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var city = galleryList.Find(x => x.Id == id);
                return !(city == null);
            });
            return _mockRepo;
        }
    }
}

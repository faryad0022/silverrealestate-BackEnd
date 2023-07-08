using Application.Contract.Persistance.EntitiesRepository.Project;
using BackEnd_UnitTest.Models.Projects.Properties;
using Domain.Entities.Project;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.Projects
{
    public static class MockPropertyRepository
    {
        public static Mock<IPropertyRepository> GetPropertyRepository()
        {
            var _mock = new Mock<IPropertyRepository>();
            var propertyList = PropertyModelGenerator.propertyTypeList;

            _mock.Setup(m => m.GetAllAsync()).ReturnsAsync(propertyList.Where(t => !t.IsDelete).ToList());
            _mock.Setup(m => m.GetPropertyListWithDetails()).ReturnsAsync(propertyList.Where(t => !t.IsDelete).ToList());

            _mock.Setup(m => m.GetPropertyWithDetails(It.IsAny<long>()))
                .ReturnsAsync((long id) =>
                {
                    return propertyList.SingleOrDefault(x => x.Id == id);
                });

            _mock.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => propertyList.FirstOrDefault(x => x.Id == id));
            _mock.Setup(m => m.AddEntityAsync(It.IsAny<Property>()))
                .ReturnsAsync((Property property) =>
                {
                    propertyList.Add(property);
                    return property;
                });
            _mock.Setup(m => m.UpdateEntity(It.IsAny<Property>())).Callback(() => { return; });
            _mock.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var property = propertyList.Find(x => x.Id == id);
                return !(property == null);
            });
            return _mock;
        }
    }
}

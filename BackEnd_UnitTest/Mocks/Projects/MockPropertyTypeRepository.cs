using Application.Contract.Persistance.EntitiesRepository.Project;
using BackEnd_UnitTest.Models.Projects.PropertyTypeData;
using Domain.Entities.Project;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.Projects
{
    public static class MockPropertyTypeRepository
    {
        public static Mock<IPropertyTypeRepository> GetPropertyTypeRepository()
        {
            var _mock = new Mock<IPropertyTypeRepository>();
            var propertytypeList = PropertyTypeModelGenerator.propertyTypeList;

            _mock.Setup(m => m.GetAllAsync()).ReturnsAsync(propertytypeList.Where(t => !t.IsDelete).ToList());
            _mock.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => propertytypeList.FirstOrDefault(x => x.Id == id));
            _mock.Setup(m => m.AddEntityAsync(It.IsAny<PropertyType>()))
                .ReturnsAsync((PropertyType propertytype) =>
                {
                    propertytypeList.Add(propertytype);
                    return propertytype;
                });
            _mock.Setup(m => m.UpdateEntity(It.IsAny<PropertyType>())).Callback(() => { return; });
            _mock.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var propertytype = propertytypeList.Find(x => x.Id == id);
                return !(propertytype == null);
            });
            return _mock;
        }
    }
}

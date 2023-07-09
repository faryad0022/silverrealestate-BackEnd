using Application.Contract.Persistence.EntitiesRepository.Project;
using BackEnd_UnitTest.Models.Projects.PropertyContractTypeData;
using Domain.Entities.Project;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.Projects
{
    public static class MockPropertyContractTypeRepository
    {
        public static Mock<IPropertyContractTypeRepository> GetPropertyContractTypeRepository()
        {
            var _mock = new Mock<IPropertyContractTypeRepository>();
            var propertyContractType = PropertyContractTypeModelGenerator.propertyContractTypeList;

            _mock.Setup(m => m.GetAllAsync()).ReturnsAsync(propertyContractType.Where(t => !t.IsDelete).ToList());
            _mock.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => propertyContractType.FirstOrDefault(x => x.Id == id));
            _mock.Setup(m => m.AddEntityAsync(It.IsAny<PropertyContractType>()))
                .ReturnsAsync((PropertyContractType propertytype) =>
                {
                    propertyContractType.Add(propertytype);
                    return propertytype;
                });
            _mock.Setup(m => m.UpdateEntity(It.IsAny<PropertyContractType>())).Callback(() => { return; });
            _mock.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var propertytype = propertyContractType.Find(x => x.Id == id);
                return !(propertytype == null);
            });
            return _mock;
        }
    }
}

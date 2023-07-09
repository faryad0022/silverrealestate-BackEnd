using Application.Contract.Persistance.EntitiesRepository.Project;
using BackEnd_UnitTest.Models.Projects.Facilities;
using Domain.Entities.Project;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.Projects
{
    public class MockFacilityRepository
    {
        public static Mock<IFacilityRepository> GetFacilityRepository()
        {
            var _mock = new Mock<IFacilityRepository>();
            var facilityList = FacilityModelGenerator.facilityList;

            _mock.Setup(m => m.GetAllAsync()).ReturnsAsync(facilityList.Where(t => !t.IsDelete).ToList());
            _mock.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => facilityList.FirstOrDefault(x => x.Id == id));
            _mock.Setup(m => m.AddEntityAsync(It.IsAny<Facility>()))
                .ReturnsAsync((Facility facility) =>
                {
                    facilityList.Add(facility);
                    return facility;
                });
            _mock.Setup(m => m.UpdateEntity(It.IsAny<Facility>())).Callback(() => { return; });
            _mock.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var facility = facilityList.Find(x => x.Id == id);
                return !(facility == null);
            });
            return _mock;
        }

    }
}

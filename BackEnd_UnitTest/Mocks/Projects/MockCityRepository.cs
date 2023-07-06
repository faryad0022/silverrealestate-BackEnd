using Application.Contract.Persistance.EntitiesRepository.Project;
using BackEnd_UnitTest.Mocks.Models.Cities;
using Domain.Entities.Project;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.Projects
{
    public static class MockCityRepository
    {
        public static Mock<ICityRepository> GetCityRepository()
        {
            var _mockRepo = new Mock<ICityRepository>();
            var cityList = CityModelGenerator.citylList;

            _mockRepo.Setup(m => m.GetCityListWithDetailsAsync()).ReturnsAsync(cityList);
            _mockRepo.Setup(m => m.GetCityListOfCountryWithDetailsAsync(It.IsAny<long>()))
                .ReturnsAsync((long countryId) =>
                {
                    return cityList.Where(c => c.CountryId == countryId).ToList();
                });
            _mockRepo.Setup(m => m.GetCityWithDetailsAsync(It.IsAny<long>()))
                .ReturnsAsync((long cityId) =>
                {
                    return cityList.FirstOrDefault(c => c.Id == cityId);
                });
            _mockRepo.Setup(m => m.GetAllAsync()).ReturnsAsync(cityList.Where(t => !t.IsDelete).ToList());
            _mockRepo.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => cityList.FirstOrDefault(x => x.Id == id));
            _mockRepo.Setup(m => m.AddEntityAsync(It.IsAny<City>()))
                .ReturnsAsync((City city) =>
                {
                    cityList.Add(city);
                    return city;
                });
            _mockRepo.Setup(m => m.UpdateEntity(It.IsAny<City>())).Callback(() => { return; });
            _mockRepo.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var city = cityList.Find(x => x.Id == id);
                return !(city == null);
            });
            return _mockRepo;
        }
    }
}

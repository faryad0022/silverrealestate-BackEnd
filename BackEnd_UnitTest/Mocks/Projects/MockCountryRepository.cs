using Application.Contract.Persistance.EntitiesRepository.Project;
using BackEnd_UnitTest.Models.Projects.CountryData;
using Domain.Entities.Project;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.Projects
{
    public static class MockCountryRepository
    {
        public static Mock<ICountryRepository> GetCountryRepository()
        {
            var _mock = new Mock<ICountryRepository>();
            var countryList = CountryModelGenerator.countryList;

            _mock.Setup(m => m.GetAllAsync()).ReturnsAsync(countryList.Where(t => !t.IsDelete).ToList());
            _mock.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => countryList.FirstOrDefault(x => x.Id == id));
            _mock.Setup(m => m.AddEntityAsync(It.IsAny<Country>()))
                .ReturnsAsync((Country country) =>
                {
                    countryList.Add(country);
                    return country;
                });
            _mock.Setup(m => m.UpdateEntity(It.IsAny<Country>())).Callback(() => { return; });
            _mock.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var country = countryList.Find(x => x.Id == id);
                return !(country == null);
            });
            return _mock;
        }
    }
}

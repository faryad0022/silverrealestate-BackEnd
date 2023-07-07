using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Models.General.About;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.General
{
    public static class MockAboutUsRepository
    {
        public static Mock<IAboutUsRepository> GetAboutUsRepository()
        {
            var _mock = new Mock<IAboutUsRepository>();
            var aboutUs = AboutUsModelGenerator.aboutUs;

            _mock.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => aboutUs.FirstOrDefault(x => x.Id == id));
            _mock.Setup(m => m.GetAllAsync())
                .ReturnsAsync(aboutUs.Where(t => !t.IsDelete).ToList());
            _mock.Setup(m => m.GetAboutUsCountAsync()).ReturnsAsync(() => aboutUs.Count);

            _mock.Setup(m => m.AddEntityAsync(It.IsAny<AboutUs>()))
                .ReturnsAsync((AboutUs about) =>
                {
                    aboutUs.Add(about);
                    return about;
                });
            _mock.Setup(m => m.UpdateEntity(It.IsAny<AboutUs>())).Callback(() => { return; });

            return _mock;
        }
    }
}

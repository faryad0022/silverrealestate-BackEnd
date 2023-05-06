using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Mocks.Models.About;
using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks
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
                .ReturnsAsync(aboutUs);
            _mock.Setup(m => m.GetAboutUsCountAsync()).ReturnsAsync(() => aboutUs.Count);
       
            _mock.Setup(m => m.AddEntityAsync(It.IsAny<AboutUs>()))
                .ReturnsAsync((AboutUs about) =>
                {
                    aboutUs.Add(about);
                    return about;
                });
            _mock.Setup(m => m.UpdateEntityAsync(It.IsAny<AboutUs>())).Callback(() => { return; });

            return _mock;
        }
    }
}

using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Mocks.Models.Banners;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks
{
    public static class MockBannerRepository
    {
        public static Mock<IBannerRepository> GetBannerRepository()
        {
            var _mock = new Mock<IBannerRepository>();
            var bannerList = BannerModelGenerator.bannerList;

            _mock.Setup(m => m.GetAllAsync()).ReturnsAsync(bannerList.Where(t=>!t.IsDelete).ToList());
            _mock.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => bannerList.FirstOrDefault(x => x.Id == id));
            _mock.Setup(m => m.AddEntityAsync(It.IsAny<Banner>()))
                .ReturnsAsync((Banner banner) =>
                {
                    bannerList.Add(banner);
                    return banner;
                });
            _mock.Setup(m => m.UpdateEntity(It.IsAny<Banner>())).Callback(() => { return; });
            return _mock;
        }
    }
}

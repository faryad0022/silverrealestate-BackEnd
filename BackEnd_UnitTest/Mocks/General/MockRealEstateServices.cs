using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Models.General.RealEstateService;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.General
{
    public static class MockRealEstateServices
    {
        public static Mock<IRealEstateServicesRepository> GetRealEstateServicesRepository()
        {
            var _mock = new Mock<IRealEstateServicesRepository>();

            _mock.Setup(r => r.GetAllAsync()).ReturnsAsync(RealEstateServicesModelGenerator.RealEstateServicesList.Where(t => !t.IsDelete).ToList());
            _mock.Setup(r => r.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => RealEstateServicesModelGenerator.RealEstateServicesList.FirstOrDefault(x => x.Id == id));
            _mock.Setup(r => r.AddEntityAsync(It.IsAny<RealEstateServices>()))
                .ReturnsAsync((RealEstateServices realEstateService) =>
                {
                    RealEstateServicesModelGenerator.RealEstateServicesList.Add(realEstateService);
                    return realEstateService;
                });
            _mock.Setup(r => r.UpdateEntity(It.IsAny<RealEstateServices>())).Callback(() => { return; });

            return _mock;
        }
    }
}

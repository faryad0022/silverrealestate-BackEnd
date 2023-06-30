using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Mocks.Models.ConstructorInformations;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks
{
    public static class MockConstructorInformationRepository
    {
        public static Mock<IConstructorInfromationRepository> GetConstructorInformationRepository()
        {
            var _mockRepo = new Mock<IConstructorInfromationRepository>();
            var constructorList = ConstructorInformationModelGenerator.constructorInformationList;

            _mockRepo.Setup(m => m.GetAllAsync()).ReturnsAsync(constructorList.Where(t => !t.IsDelete).ToList());
            _mockRepo.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => constructorList.FirstOrDefault(x => x.Id == id));
            _mockRepo.Setup(m => m.AddEntityAsync(It.IsAny<ConstructorInformation>()))
                .ReturnsAsync((ConstructorInformation constructor) =>
                {
                    constructorList.Add(constructor);
                    return constructor;
                });
            _mockRepo.Setup(m => m.UpdateEntity(It.IsAny<ConstructorInformation>())).Callback(() => { return; });

            return _mockRepo;

        }
    }
}

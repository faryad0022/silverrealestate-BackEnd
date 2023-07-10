using Application.Contract.Persistence.EntitiesRepository.Project;
using BackEnd_UnitTest.Models.Projects.PropertyPlans;
using Domain.Entities.Project;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.Projects
{
    public class MockPropertyPlanRepository
    {
        public static Mock<IPropertyPlanRepository> GetPropertyPlanRepository()
        {
            var _mockRepo = new Mock<IPropertyPlanRepository>();
            var planList = PropertyPlanModelGenerator.propertyPlans;

            _mockRepo.Setup(m => m.GetEntityAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                return planList.SingleOrDefault(c => c.Id == id);
            });
            _mockRepo.Setup(m => m.GetListOfPlanOfProperty(It.IsAny<long>()))
                .ReturnsAsync((long propertyId) =>
                {
                    return planList.Where(c => c.PropertyId == propertyId).ToList();
                });
            _mockRepo.Setup(m => m.AddEntityAsync(It.IsAny<PropertyPlan>()))
                .ReturnsAsync((PropertyPlan plan) =>
                {
                    planList.Add(plan);
                    return plan;
                });
            _mockRepo.Setup(m => m.UpdateEntity(It.IsAny<PropertyPlan>())).Callback(() => { return; });
            _mockRepo.Setup(m => m.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var plan = planList.Find(x => x.Id == id);
                return !(plan == null);
            });
            return _mockRepo;
        }

    }
}

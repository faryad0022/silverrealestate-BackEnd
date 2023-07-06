using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Mocks.Models.Socials;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.General
{
    public static class MockSocialRepository
    {
        public static Mock<ISocialRepository> GetSocialRepository()
        {
            var socialList = SocialModelGenerator.socialList;
            var mockRepo = new Mock<ISocialRepository>();


            mockRepo.Setup(r => r.ExistAsync(It.IsAny<long>())).ReturnsAsync((long id) =>
            {
                var social = socialList.FirstOrDefault(x => x.Id == id);
                return social != null;
            });

            //GetAll
            mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(socialList.Where(t => !t.IsDelete).ToList());


            //Get
            mockRepo.Setup(r => r.GetEntityAsync(It.IsAny<long>())).ReturnsAsync((long id) =>

                socialList.FirstOrDefault(x => x.Id == id)
            );


            //Add
            mockRepo.Setup(r => r.AddEntityAsync(It.IsAny<Social>())).ReturnsAsync((Social social) =>
            {
                SocialModelGenerator.socialList.Add(social);
                return social;
            });

            mockRepo.Setup(r => r.UpdateEntity(It.IsAny<Social>())).Callback(() => { return; });


            //Delete
            mockRepo.Setup(r => r.DeleteEntity(It.IsAny<Social>())).Callback(() =>
            {
                SocialModelGenerator.socialList.Remove(It.IsAny<Social>());
            });


            //Update
            mockRepo.Setup(r => r.UpdateEntity(It.IsAny<Social>())).Callback(() => { return; });
            return mockRepo;
        }
    }
}

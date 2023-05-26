using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Mocks.Models;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System;
using System.Linq;

namespace BackEnd_UnitTest.Mocks
{
    public static class MockTeamMemberSocialRepository
    {
        public static Mock<ITeamMemberSocialRepository> GetTeamMemberSocialRepository()
        {
            var _mock = new Mock<ITeamMemberSocialRepository>();
            var teamMemberSocialList = TeamMemberSocialModelGenerator.teamMemberSocialsList;
            //Get All
            _mock.Setup(s => s.GetAllAsync()).ReturnsAsync(teamMemberSocialList);
            //Get All Withdetails
            _mock.Setup(s => s.GetTeamMemberSocialListWithDetails()).ReturnsAsync(teamMemberSocialList);
            //Get By Id
            _mock.Setup(s => s.GetEntityAsync(It.IsAny<long>())).ReturnsAsync((long Id) =>
                            teamMemberSocialList.Where(t => t.Id == Id).FirstOrDefault());
            //Get By Id With Details
            _mock.Setup(s => s.GetTeamMemberSocialWithDetails(It.IsAny<long>())).ReturnsAsync((long Id) =>
                            teamMemberSocialList.Where(t => t.Id == Id).FirstOrDefault());
            //Add Entity
            _mock.Setup(s => s.AddEntityAsync(It.IsAny<TeamMemberSocial>())).ReturnsAsync((TeamMemberSocial teamMemberSocial) =>
            {
                teamMemberSocialList.Add(teamMemberSocial);
                return teamMemberSocial;
            });

            //Update Entity
            _mock.Setup(r => r.UpdateEntityAsync(It.IsAny<TeamMemberSocial>())).Callback(() => { return; });

            //Change selected status
            _mock.Setup(r => r.ChangeSelectedStatusAsync(It.IsAny<TeamMemberSocial>())).Callback((TeamMemberSocial teamMemberSocial) =>
            {
                teamMemberSocial.IsSelected = !teamMemberSocial.IsSelected;
                teamMemberSocial.LastUpdateDate = DateTime.Now;
                return;
            });

            return _mock;
        }
    }
}

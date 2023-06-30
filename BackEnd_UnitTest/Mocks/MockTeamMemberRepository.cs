using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Mocks.Models.TeamMembers;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System;
using System.Linq;

namespace BackEnd_UnitTest.Mocks
{
    public static class MockTeamMemberRepository
    {
        public static Mock<ITeamMemberRepository> GetTeamMemberRepository()
        {
            var _mock = new Mock<ITeamMemberRepository>();

            var teamMemberList = TeamMemberModelGenerator.TeamMemberList;

            //Get All
            _mock.Setup(s => s.GetAllAsync()).ReturnsAsync(teamMemberList.Where(t => !t.IsDelete).ToList());

            //Get By Id
            _mock.Setup(s => s.GetEntityAsync(It.IsAny<long>())).ReturnsAsync((long Id) =>
                            teamMemberList.Where(t => t.Id == Id).FirstOrDefault());

            //Add Entity
            _mock.Setup(s => s.AddEntityAsync(It.IsAny<TeamMember>())).ReturnsAsync((TeamMember teamMember) =>
            {
                teamMemberList.Add(teamMember);
                return teamMember;
            });

            //Update Entity
            _mock.Setup(r => r.UpdateEntity(It.IsAny<TeamMember>())).Callback(() => { return; });

            //Change selected status
            _mock.Setup(r => r.ChangeSelectedStatus(It.IsAny<TeamMember>())).Callback((TeamMember teamMember) =>
            {
                teamMember.IsSelected = !teamMember.IsSelected;
                teamMember.LastUpdateDate = DateTime.Now;
                return;
            });

            return _mock;
        }
    }
}

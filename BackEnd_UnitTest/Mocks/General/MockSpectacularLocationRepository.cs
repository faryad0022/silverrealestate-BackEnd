using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Mocks.Models.SpectacularLocations;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.General
{
    public static class MockSpectacularLocationRepository
    {
        public static Mock<ISpectacularlocationRepository> GetSpectacularLocationRepositories()
        {
            var _mock = new Mock<ISpectacularlocationRepository>();
            var spectacularLocationList = SpectacularLocationModelGenerator.spectacularLocationList;
            //Get All
            _mock.Setup(s => s.GetAllAsync()).ReturnsAsync(spectacularLocationList.Where(t => !t.IsDelete).ToList());

            //Get By Id
            _mock.Setup(s => s.GetEntityAsync(It.IsAny<long>())).ReturnsAsync((long Id) => spectacularLocationList.FirstOrDefault(s => s.Id == Id));
            //Add
            _mock.Setup(s => s.AddEntityAsync(It.IsAny<Spectacularlocation>())).ReturnsAsync((Spectacularlocation spectacularLocation) =>
            {
                spectacularLocationList.Add(spectacularLocation);
                return spectacularLocation;
            });
            //Delete
            _mock.Setup(r => r.DeleteEntity(It.IsAny<Spectacularlocation>())).Callback(() =>
            {
                spectacularLocationList.Remove(It.IsAny<Spectacularlocation>());
            });
            //Update
            _mock.Setup(r => r.UpdateEntity(It.IsAny<Spectacularlocation>())).Callback(() => { return; });
            //Change
            _mock.Setup(r => r.ChangeSelectedStatus(It.IsAny<Spectacularlocation>())).Callback((Spectacularlocation spectacularlocation) =>
            {
                spectacularlocation.IsSelected = !spectacularlocation.IsSelected;
                spectacularlocation.LastUpdateDate = DateTime.Now;
                return;
            });
            return _mock;
        }
    }
}

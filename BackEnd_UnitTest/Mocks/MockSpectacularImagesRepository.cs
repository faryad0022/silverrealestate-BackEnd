using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Mocks.Models.SoectacularImages;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System;
using System.Linq;

namespace BackEnd_UnitTest.Mocks
{
    public static class MockSpectacularImagesRepository
    {
        public static Mock<ISpectacularLocationImageRepository> GetSpectacularImagesRepository()
        {
            var _mock = new Mock<ISpectacularLocationImageRepository>();

            var spectacularLocationImageList = SpectacularLocationImageModelGenerator.SpectacularLocationImagesList;
            //Get All
            _mock.Setup(s => s.GetAllAsync()).ReturnsAsync(spectacularLocationImageList);
            //Get All WithDetails
            _mock.Setup(s => s.GetSpectacularLocationImagesListWithDetails()).ReturnsAsync(spectacularLocationImageList);
            //Get By Id WithDetails
            _mock.Setup(s => s.GetSpectacularLocationImagesWithDetails(It.IsAny<long>())).ReturnsAsync((long Id) => spectacularLocationImageList.FirstOrDefault(s => s.Id == Id));

            //Get By Id
            _mock.Setup(s => s.GetEntityAsync(It.IsAny<long>())).ReturnsAsync((long Id) => spectacularLocationImageList.FirstOrDefault(s => s.Id == Id));
            //Add
            _mock.Setup(s => s.AddEntityAsync(It.IsAny<SpectacularLocationImages>())).ReturnsAsync((SpectacularLocationImages spectacularLocationImage) =>
            {
                spectacularLocationImageList.Add(spectacularLocationImage);
                return spectacularLocationImage;
            });
            //Delete
            _mock.Setup(r => r.DeleteEntityAsync(It.IsAny<SpectacularLocationImages>())).Callback(() =>
            {
                spectacularLocationImageList.Remove(It.IsAny<SpectacularLocationImages>());
            });
            //Update
            _mock.Setup(r => r.UpdateEntityAsync(It.IsAny<SpectacularLocationImages>())).Callback(() => { return; });
            //Change
            _mock.Setup(r => r.ChangeSelectedStatusAsync(It.IsAny<SpectacularLocationImages>())).Callback((SpectacularLocationImages spectacularlocation) =>
            {
                spectacularlocation.IsSelected = !spectacularlocation.IsSelected;
                spectacularlocation.LastUpdateDate = DateTime.Now;
                return;
            });
            return _mock;
        }
    }
}

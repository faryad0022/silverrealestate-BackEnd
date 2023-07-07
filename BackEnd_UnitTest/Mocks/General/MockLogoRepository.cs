﻿using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Models.General.Logos;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.General
{
    public static class MockLogoRepository
    {
        public static Mock<ILogoRepository> GetLogoRepository()
        {
            var _mock = new Mock<ILogoRepository>();


            _mock.Setup(r => r.GetAllAsync()).ReturnsAsync(LogoModelGenerator.LogoList.Where(t => !t.IsDelete).ToList());
            _mock.Setup(r => r.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => LogoModelGenerator.LogoList.FirstOrDefault(x => x.Id == id));
            _mock.Setup(r => r.AddEntityAsync(It.IsAny<Logo>()))
                .ReturnsAsync((Logo logo) =>
                {
                    LogoModelGenerator.LogoList.Add(logo);
                    return logo;
                });
            _mock.Setup(r => r.UpdateEntity(It.IsAny<Logo>())).Callback(() => { return; });



            return _mock;
        }
    }
}

﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.BannerFeatures.Handler.Commands;
using Application.features.GeneralInformations.BannerFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.General.Banners;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.Banners.Commands
{
    public class UpdateBannerLinkRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdateBannerLinkRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateBannerLink_Valid()
        {
            var handler = new UpdateBannerLinkRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateBannerLinkRequest() { updateBannerLinkDTO = BannerModelGenerator.updateBannerLinkDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateBannerLink_NotFound_InValid()
        {
            var handler = new UpdateBannerLinkRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateBannerLinkRequest() { updateBannerLinkDTO = BannerModelGenerator.updateBannerLinkDTO_NotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();
        }
    }
}
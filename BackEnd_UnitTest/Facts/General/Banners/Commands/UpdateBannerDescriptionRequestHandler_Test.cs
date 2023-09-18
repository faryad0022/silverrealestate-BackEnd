﻿using Application.Const.Response;
using Application.Contract.Persistence;
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
    public class UpdateBannerDescriptionRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdateBannerDescriptionRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateBannerDescription_Valid()
        {
            var handler = new UpdateBannerDescriptionRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateBannerDescriptionRequest() { updateBannerDescriptionDTO = BannerModelGenerator.updateBannerDescriptionDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateBannerDescription_NotFound_InValid()
        {
            var handler = new UpdateBannerDescriptionRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateBannerDescriptionRequest() { updateBannerDescriptionDTO = BannerModelGenerator.updateBannerDescriptionDTO_NotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();
        }
    }
}

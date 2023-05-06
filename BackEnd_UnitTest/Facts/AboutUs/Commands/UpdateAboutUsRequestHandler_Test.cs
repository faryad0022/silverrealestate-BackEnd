﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.AboutUsFeatures.Handler.Commands;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.About;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.AboutUs.Commands
{
    public class UpdateAboutUsRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepo;
        public UpdateAboutUsRequestHandler_Test()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task Update_AboutUs_Valid()
        {
            var handler = new UpdateAboutUsRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new UpdateAboutUsRequest() { updateAboutUsDTO = AboutUsModelGenerator.updateAboutUsDTO_Valid }, CancellationToken.None);

            result.Errors.ShouldBeNull();
            result.Tentity.ShouldNotBeNull();
            result.Tentities.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.Success);

        }
        [Fact]
        public async Task Update_AboutUs_Validation_InValid()
        {
            var handler = new UpdateAboutUsRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new UpdateAboutUsRequest() { updateAboutUsDTO = AboutUsModelGenerator.updateAboutUsDTO_InValid }, CancellationToken.None);

            result.Errors.ShouldNotBeNull();
            result.Tentity.ShouldBeNull();
            result.Tentities.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.ValidationError);

        }
        [Fact]
        public async Task Update_AboutUs_NotFound_InValid()
        {
            var handler = new UpdateAboutUsRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new UpdateAboutUsRequest() { updateAboutUsDTO = AboutUsModelGenerator.updateAboutUsDTO_NotFound_InValid }, CancellationToken.None);

            result.Errors.ShouldBeNull();
            result.Tentity.ShouldBeNull();
            result.Tentities.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.NotFound);

        }
    }
}

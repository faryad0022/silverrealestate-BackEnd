﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.LogoFeatures.Handler.Queries;
using Application.features.GeneralInformations.LogoFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.Logos.Queries
{
    public class GetLogoRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mockRepo;
        public GetLogoRequestHandler_Test()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetLogo_Valid()
        {
            var handler = new GetLogoRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new GetLogoRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();



        }
        [Fact]
        public async Task GetLogo_NotFound_InValid()
        {
            var handler = new GetLogoRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new GetLogoRequest() { Id = 3 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();



        }



    }

}
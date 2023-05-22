﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Handler.Queries;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.RealEstateServices.Queries
{
    public class GetRealEstateServiceRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetRealEstateServiceRequestHandler_Test()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetRealEstateService_Valid()
        {
            var handler = new GetRealEstateServiceRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetRealEstateServiceRequest() { Id = 2 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldNotBeNull();
            result.Tentity.Name.ShouldBe("mojgan");
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
        }
        [Fact]
        public async Task GetRealEstateService_Valid2()
        {
            var handler = new GetRealEstateServiceRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetRealEstateServiceRequest() { Id = 3 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldNotBeNull();
            result.Tentity.Name.ShouldBe("faryad");
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
        }
        [Fact]
        public async Task GetRealEstateService_InValid()
        {
            var handler = new GetRealEstateServiceRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetRealEstateServiceRequest() { Id = 20 }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldBeNull();
        }
    }
}

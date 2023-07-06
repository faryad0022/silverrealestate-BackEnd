﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.CountryFeatures.Handler.Queries;
using Application.features.Projects.CountryFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Countries.Queries
{
    public class GetCountryListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetCountryListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetCountryList_Valid()
        {
            var handler = new GetCountryListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetCountryListRequest(), CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task Get_Selected_GetCountryList_Valid()
        {
            var handler = new GetCountryListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetCountryListRequest() { justShowSelected = true }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();



        }
    }
}

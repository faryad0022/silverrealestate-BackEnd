using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.ConstructorInformations.Handler.Queries;
using Application.features.GeneralInformations.ConstructorInformations.Request.Queries;
using Application.features.Projects.CountryFeatures.Handler.Queries;
using Application.features.Projects.CountryFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Countries.Queries
{
    public class GetCountryRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock; 
        public GetCountryRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetCountry_Valid()
        {
            var handler = new GetCountryRequestHandler(_mock.Object,_mapper);
            var result = await handler.Handle(new GetCountryRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetCountry_NotFound_InValid()
        {
            var handler = new GetCountryRequestHandler(_mock.Object, _mapper);
            var result = await handler.Handle(new GetCountryRequest() { Id = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
    }
}

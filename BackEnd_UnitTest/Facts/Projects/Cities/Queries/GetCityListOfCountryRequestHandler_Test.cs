using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.CityFeatures.Handler.Queries;
using Application.features.Projects.CityFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.Cities.Queries
{
    public class GetCityListOfCountryRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public GetCityListOfCountryRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetCityListOfCountry_Valid()
        {
            var handler = new GetCityListOfCountryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetCityListOfCountryRequest() { countryId = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetCityListOfCountry_NotFound_InValid()
        {
            var handler = new GetCityListOfCountryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetCityListOfCountryRequest() { countryId = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NoContent);
            result.Errors.ShouldBeNull();


        }
    }
}

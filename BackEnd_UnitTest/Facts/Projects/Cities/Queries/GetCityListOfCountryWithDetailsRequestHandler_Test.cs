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
    public class GetCityListOfCountryWithDetailsRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public GetCityListOfCountryWithDetailsRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task GetCityListOfCountryWithDetails_Valid()
        {
            var handler = new GetCityListOfCountryWithDetailsRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetCityListOfCountryWithDetailsRequest() { countryId = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetCityListOfCountryWithDetails_NotFound_InValid()
        {
            var handler = new GetCityListOfCountryWithDetailsRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetCityListOfCountryWithDetailsRequest() { countryId = 10 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
    }
}

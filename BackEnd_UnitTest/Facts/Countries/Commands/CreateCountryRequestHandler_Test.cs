using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.CountryFeatures.Handler.Commands;
using Application.features.Projects.CountryFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.CountryData;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Countries.Commands
{
    public class CreateCountryRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreateCountryRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task CreateCountry_Valid()
        {
            var handler = new CreateCountryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateCountryRequest() { createCountryDTO = CountryModelGenerator.createCountryDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task CreateCountry_Validation_InValid()
        {
            var handler = new CreateCountryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateCountryRequest() { createCountryDTO = CountryModelGenerator.createCountryDTO_Validation_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);

            result.Errors.ShouldNotBeNull();


        }
    }
}

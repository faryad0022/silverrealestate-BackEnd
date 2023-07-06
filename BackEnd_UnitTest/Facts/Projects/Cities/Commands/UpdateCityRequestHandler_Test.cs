using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.CityFeatures.Handler.Commands;
using Application.features.Projects.CityFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.Cities;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.Cities.Commands
{
    public class UpdateCityRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public UpdateCityRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateCity_valid()
        {
            var handler = new UpdateCityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateCityRequest() { updateCityDTO = CityModelGenerator._updateCityDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();

        }

        [Fact]
        public async Task UpdateCity_Validation_Invalid()
        {
            var handler = new UpdateCityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateCityRequest() { updateCityDTO = CityModelGenerator._updateCityDTO_ValidationError_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
        [Fact]
        public async Task UpdateCity_Validation_CityNotFound_Invalid()
        {
            var handler = new UpdateCityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateCityRequest() { updateCityDTO = CityModelGenerator._updateCityDTO_ValidationError_CityNotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
        [Fact]
        public async Task UpdateCity_Validation_CountryNotFound_Invalid()
        {
            var handler = new UpdateCityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateCityRequest() { updateCityDTO = CityModelGenerator._updateCityDTO_ValidationError_CountryNotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }

    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.Projects.Cities;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.Cities.Commands
{
    public class CreateCityRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _mock;
        public CreateCityRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreateCity_valid()
        {
            var handler = new CreateCityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateCityRequest() { createCityDTO = CityModelGenerator._createCityDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();

        }
        [Fact]
        public async Task CreateCity_ValidationError_Invalid()
        {
            var handler = new CreateCityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateCityRequest() { createCityDTO = CityModelGenerator._createCityDTO_ValidationError_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
        [Fact]
        public async Task CreateCity_ValidationError_NotExist_Invalid()
        {
            var handler = new CreateCityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateCityRequest() { createCityDTO = CityModelGenerator._createCityDTO_ValidationError_NotExist_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
        [Fact]
        public async Task CreateCity_ValidationError_Duplicate_Invalid()
        {
            var handler = new CreateCityRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateCityRequest() { createCityDTO = CityModelGenerator._createCityDTO_ValidationError_Duplicate_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();

        }
    }
}

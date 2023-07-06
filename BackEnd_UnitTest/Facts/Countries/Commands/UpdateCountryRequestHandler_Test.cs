using Application.Const.Response;
using Application.Contract.Persistence;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Application.Profiles;
using Application.features.Projects.CountryFeatures.Handler.Commands;
using Application.features.Projects.CountryFeatures.Request.Commands;
using BackEnd_UnitTest.Mocks.Models.CountryData;
using Shouldly;

namespace BackEnd_UnitTest.Facts.Countries.Commands
{
    public class UpdateCountryRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdateCountryRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }

        [Fact]
        public async Task UpdateCountryRequestHandler_Valid()
        {
            var handler = new UpdateCountryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateCountryRequest() { updateCountryDTO = CountryModelGenerator.updateCountryDTO_Valid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateCountryRequestHandler_Validation_InValid()
        {
            var handler = new UpdateCountryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateCountryRequest() { updateCountryDTO = CountryModelGenerator.updateCountryDTO_Validation_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
        [Fact]
        public async Task UpdateCountryRequestHandler_Validation_NotFound_InValid()
        {
            var handler = new UpdateCountryRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateCountryRequest() { updateCountryDTO = CountryModelGenerator.updateCountryDTO_Validation_Notfound_InValid }, CancellationToken.None);


            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
        }
    }
}

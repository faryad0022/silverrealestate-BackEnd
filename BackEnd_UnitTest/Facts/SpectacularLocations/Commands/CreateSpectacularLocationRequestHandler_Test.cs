using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Handler.Commands;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.SpectacularLocations;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.SpectacularLocations.Commands
{
    public class CreateSpectacularLocationRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitofWork;
        public CreateSpectacularLocationRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitofWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreateSpectacularLocation_Valid()
        {
            var handler = new CreateSpectacularLocationRequestHandler(_mapper, _unitofWork.Object);
            var result = await handler.Handle(new CreateSpectacularLocationRequest() { createSpectacularLocationDTO = SpectacularLocationModelGenerator.CreateSpectacularLocationDTO_Valid }, CancellationToken.None);

            result.Tentities.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldBeOfType(typeof(SpectacularLocationDTO));
            result.Tentity.Name.ShouldBe("Girne");
        }
        [Fact]
        public async Task CreateSpectacularLocation_InValid()
        {
            var handler = new CreateSpectacularLocationRequestHandler(_mapper, _unitofWork.Object);
            var result = await handler.Handle(new CreateSpectacularLocationRequest() { createSpectacularLocationDTO = SpectacularLocationModelGenerator.CreateSpectacularLocationDTO_ValidationError_InValid }, CancellationToken.None);

            result.Tentities.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.ValidationError);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldNotBeNull();
        }
    }
}

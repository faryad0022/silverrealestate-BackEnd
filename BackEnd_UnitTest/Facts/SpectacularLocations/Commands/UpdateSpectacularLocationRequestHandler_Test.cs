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
    public class UpdateSpectacularLocationRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitOfWork;
        public UpdateSpectacularLocationRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateSpectacularLocation_Valid()
        {
            var handler = new UpdateSpectacularLocationRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateSpectacularLocationRequest() { updateSpectacularLocationDTO = SpectacularLocationModelGenerator.UpdateSpectacularLocationDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentity.ShouldBeOfType(typeof(SpectacularLocationDTO));
            result.Tentity.ShouldNotBeNull();
        }

        [Fact]
        public async Task UpdateSpectacularLocation_NotFound_InValid()
        {
            var handler = new UpdateSpectacularLocationRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateSpectacularLocationRequest() { updateSpectacularLocationDTO = SpectacularLocationModelGenerator.UpdateSpectacularLocationDTO_NotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.NotFound);
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentity.ShouldBeNull();
        }

        [Fact]
        public async Task UpdateSpectacularLocation_ValidationError_InValid()
        {
            var handler = new UpdateSpectacularLocationRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new UpdateSpectacularLocationRequest() { updateSpectacularLocationDTO = SpectacularLocationModelGenerator.UpdateSpectacularLocationDTO_ValidationError_InValid }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.ValidationError);
            result.Tentities.ShouldBeNull();
            result.Errors.ShouldNotBeNull();
            result.Tentity.ShouldBeOfType(typeof(SpectacularLocationDTO));
            result.Tentity.ShouldNotBeNull();
        }

    }
}

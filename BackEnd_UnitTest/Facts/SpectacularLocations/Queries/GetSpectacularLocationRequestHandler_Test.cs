using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Handler.Queries;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.SpectacularLocations.Queries
{
    public class GetSpectacularLocationRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitofWork;
        public GetSpectacularLocationRequestHandler_Test()
        {
            _unitofWork = MockUniOfWork.GetMockUnitOfWork();
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
        }
        [Fact]
        public async Task GetSpectacularLocation()
        {
            var handler = new GetSpectacularLocationRequestHandler(_unitofWork.Object, _mapper);
            var result = await handler.Handle(new GetSpectacularLocationRequest() { Id = 1 }, CancellationToken.None);

            result.Tentities.ShouldBeNull();
            result.Tentity.Name.ShouldBe("Ghost City");
            result.Tentity.ShouldBeOfType(typeof(SpectacularLocationDTO));
            result.Errors.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.Success);
        }
        [Fact]
        public async Task GetSpectacularLocation_NotFound_Invalid()
        {
            var handler = new GetSpectacularLocationRequestHandler(_unitofWork.Object, _mapper);
            var result = await handler.Handle(new GetSpectacularLocationRequest() { Id = 10 }, CancellationToken.None);

            result.Tentities.ShouldBeNull();
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Status.ShouldBe(ResponseStatus.NotFound);
        }
    }
}

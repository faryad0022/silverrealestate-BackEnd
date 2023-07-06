using Application.Const.Response;
using Application.Contract.Persistence;
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

namespace BackEnd_UnitTest.Facts.General.SpectacularLocations.Queries
{
    public class GetSpectacularLocationListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _unitofWork;
        public GetSpectacularLocationListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _unitofWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetSpectacularLocationList_Valid()
        {
            var handler = new GetSpectacularLocationListRequestHandler(_mapper, _unitofWork.Object);
            var result = await handler.Handle(new GetSpectacularLocationListRequest(), CancellationToken.None);

            result.Errors.ShouldBeNull();
            result.Status.ShouldBe(StatusMessage.Success);
        }
        [Fact]
        public async Task GetSpectacularLocationList_JustShowSelected_Valid()
        {
            var handler = new GetSpectacularLocationListRequestHandler(_mapper, _unitofWork.Object);
            var result = await handler.Handle(new GetSpectacularLocationListRequest() { justShowSelected = true }, CancellationToken.None);

            result.Errors.ShouldBeNull();
            result.Status.ShouldBe(StatusMessage.Success);
        }
    }
}

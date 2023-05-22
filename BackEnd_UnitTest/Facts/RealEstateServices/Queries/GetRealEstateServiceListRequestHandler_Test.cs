using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Handler.Queries;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.RealEstateServices.Queries
{
    public class GetRealEstateServiceListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetRealEstateServiceListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetRealEstateServiceList_Valid()
        {
            var handler = new GetRealEstateServiceListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetRealEstateServiceListRequest(), CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldNotBeNull();

        }
        [Fact]
        public async Task Get_Selected_RealEstateServiceList_Valid()
        {
            var handler = new GetRealEstateServiceListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetRealEstateServiceListRequest() { justShowSelected = true }, CancellationToken.None);

            result.Status.ShouldBe(ResponseStatus.Success);
            result.Tentity.ShouldBeNull();
            result.Errors.ShouldBeNull();
            result.Tentities.ShouldNotBeNull();
            result.Tentities.Count.ShouldBe(3);


        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.AddressFeatures.Handler.Queries;
using Application.features.GeneralInformations.AddressFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Addresses.Queries
{
    public class GetAddressRequest_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetAddressRequest_Test()
        {
            _mock = MockUniOfWork.GetMockUnitOfWork();
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
        }
        [Fact]
        public async Task GetAddress_Valid()
        {
            var handler = new GetAddressRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetAddressRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task GetAddress_NotFound_InValid()
        {
            var handler = new GetAddressRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetAddressRequest() { Id = 3 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);

            result.Errors.ShouldBeNull();
        }
    }
}

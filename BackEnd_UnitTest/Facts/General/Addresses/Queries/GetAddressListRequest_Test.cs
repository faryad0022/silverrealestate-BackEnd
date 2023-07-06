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

namespace BackEnd_UnitTest.Facts.General.Addresses.Queries
{
    public class GetAddressListRequest_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetAddressListRequest_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetAddressList_Valid()
        {
            var handler = new GetAddressListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetAddressListRequest(), CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

        }

        [Fact]
        public async Task Get_Selected_AddressList_Valid()
        {
            var handler = new GetAddressListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetAddressListRequest() { justShowSelected = true }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.AddressFeatures.Handler.Commands;
using Application.features.GeneralInformations.AddressFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.Addresses.Commands
{
    public class ChangeAddressDTOStatusRequest_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public ChangeAddressDTOStatusRequest_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateAddress_Valid()
        {
            var handler = new ChangeAddressDTOStatusRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new ChangeAddressDTOStatusRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);


        }

        [Fact]
        public async Task UpdateAddress_NotFound_InValid()
        {
            var handler = new ChangeAddressDTOStatusRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new ChangeAddressDTOStatusRequest() { Id = 4 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);


        }
    }
}

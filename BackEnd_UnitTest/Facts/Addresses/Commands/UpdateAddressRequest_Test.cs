using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.AddressFeatures.Handler.Commands;
using Application.features.GeneralInformations.AddressFeatures.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.Addresses;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Addresses.Commands
{
    public class UpdateAddressRequest_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdateAddressRequest_Test()
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
            var handler = new UpdateAddressRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateAddressRequest() { updateAddressDTO = AddressModelGenerator.updateAddressDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);


        }
        [Fact]
        public async Task UpdateAddress_Validation_InValid()
        {
            var handler = new UpdateAddressRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateAddressRequest() { updateAddressDTO = AddressModelGenerator.updateAddressDTO_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();


        }

        [Fact]
        public async Task UpdateAddress_NotFound_InValid()
        {
            var handler = new UpdateAddressRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateAddressRequest() { updateAddressDTO = AddressModelGenerator.updateAddressDTO_NotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();


        }
    }
}

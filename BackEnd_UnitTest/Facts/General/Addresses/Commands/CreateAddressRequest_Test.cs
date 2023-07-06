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

namespace BackEnd_UnitTest.Facts.General.Addresses.Commands
{
    public class CreateAddressRequest_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreateAddressRequest_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreateAddress_Valid()
        {
            var handler = new CreateAddressRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateAddressRequest() { createAddressDTO = AddressModelGenerator.AddressDTO }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);


        }
        [Fact]
        public async Task CreateAddress_Email_InValid()
        {
            var handler = new CreateAddressRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateAddressRequest() { createAddressDTO = AddressModelGenerator.AddressDTO_Invalid_Email }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);


            result.Errors.ShouldNotBeNull();
        }
    }
}

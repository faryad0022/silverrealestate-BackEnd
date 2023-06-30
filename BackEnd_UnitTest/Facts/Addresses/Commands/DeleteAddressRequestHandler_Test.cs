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

namespace BackEnd_UnitTest.Facts.Addresses.Commands
{
    public class DeleteAddressRequestHandler_Test
    {
        private IMapper _mapper;
        private Mock<IUnitofWork> _unitOfWork;
        public DeleteAddressRequestHandler_Test()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapConfig.CreateMapper();
            _unitOfWork = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task DeleteAddressRequestHandler_Valid()
        {
            var handler = new DeleteAddressRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new DeleteAddressRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);


            result.Errors.ShouldBeNull();
        }

        [Fact]
        public async Task DeleteAddressRequestHandler_NotFound_InValid()
        {
            var handler = new DeleteAddressRequestHandler(_mapper, _unitOfWork.Object);
            var result = await handler.Handle(new DeleteAddressRequest() { Id = 15 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);


            result.Errors.ShouldBeNull();
        }
    }
}

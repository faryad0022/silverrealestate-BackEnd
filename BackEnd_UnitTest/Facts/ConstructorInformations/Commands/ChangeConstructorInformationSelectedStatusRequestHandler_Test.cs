using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.ConstructorInformations.Handler.Commands;
using Application.features.GeneralInformations.ConstructorInformations.Request.Commands;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.ConstructorInformations.Commands
{
    public class ChangeConstructorInformationSelectedStatusRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public ChangeConstructorInformationSelectedStatusRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task ChangeConstructorInformationSelectedStatus_Valid()
        {
            var handler = new ChangeConstructorInformationSelectedStatusRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new ChangeConstructorInformationSelectedStatusRequest() { Id = 2 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task ChangeConstructorInformationSelectedStatus_NotFound_InValid()
        {
            var handler = new ChangeConstructorInformationSelectedStatusRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new ChangeConstructorInformationSelectedStatusRequest() { Id = 7 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);

            result.Errors.ShouldBeNull();


        }
    }
}

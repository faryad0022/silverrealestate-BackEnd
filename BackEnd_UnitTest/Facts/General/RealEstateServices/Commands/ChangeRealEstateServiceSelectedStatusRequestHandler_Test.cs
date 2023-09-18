using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.RealEstateServices.Commands
{
    public class ChangeRealEstateServiceSelectedStatusRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public ChangeRealEstateServiceSelectedStatusRequestHandler_Test()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mapConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task ChangeRealEstateServiceSelectedStatus_Valid()
        {
            var handler = new ChangeRealEstateServiceSelectedStatusRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new ChangeRealEstateServiceSelectedStatusRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);


        }

        [Fact]
        public async Task ChangeRealEstateServiceSelectedStatus_NotFound_InValid()
        {
            var handler = new ChangeRealEstateServiceSelectedStatusRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new ChangeRealEstateServiceSelectedStatusRequest() { Id = 5 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);


        }
    }
}

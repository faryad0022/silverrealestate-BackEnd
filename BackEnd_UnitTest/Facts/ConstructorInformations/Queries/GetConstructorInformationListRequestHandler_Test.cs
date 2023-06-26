using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.ConstructorInformations.Handler.Queries;
using Application.features.GeneralInformations.ConstructorInformations.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.ConstructorInformations.Queries
{
    public class GetConstructorInformationListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetConstructorInformationListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetConstructorInformationList_Valid()
        {
            var handler = new GetConstructorInformationListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetConstructorInformationListRequest(), CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            
            result.Errors.ShouldBeNull();
            

        }
        [Fact]
        public async Task Get_Selected_GetConstructorInformationList_Valid()
        {
            var handler = new GetConstructorInformationListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetConstructorInformationListRequest() { justShowSelected = true }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            
            result.Errors.ShouldBeNull();
            


        }
    }
}

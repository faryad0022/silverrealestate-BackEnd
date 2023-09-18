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

namespace BackEnd_UnitTest.Facts.Projects.Facilities.Queries
{
    public class GetFacilityListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetFacilityListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetFacilityList_Valid()
        {
            var handler = new GetFacilityListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetFacilityListRequest(), CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task Get_Selected_GetFacilityList_Valid()
        {
            var handler = new GetFacilityListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetFacilityListRequest() { Selected = true }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();



        }
    }
}

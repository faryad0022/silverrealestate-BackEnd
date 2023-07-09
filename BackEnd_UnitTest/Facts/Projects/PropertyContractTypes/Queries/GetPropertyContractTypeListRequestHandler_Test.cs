using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.Projects.PropertyContractTypeFeatures.Handler.Queries;
using Application.features.Projects.PropertyContractTypeFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.Projects.PropertyContractTypes.Queries
{
    public class GetPropertyContractTypeListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetPropertyContractTypeListRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task GetPropertyContractTypeList_Valid()
        {
            var handler = new GetPropertyContractTypeListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyContractTypeListRequest(), CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
        [Fact]
        public async Task Get_Selected_GetPropertyContractTypeList_Valid()
        {
            var handler = new GetPropertyContractTypeListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetPropertyContractTypeListRequest() { justSelected = true }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            result.Errors.ShouldBeNull();
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Queries;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.CommonQuestions.Queries
{
    public class GetCommonQuestionListRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public GetCommonQuestionListRequestHandler_Test()
        {
            _mock = MockUniOfWork.GetMockUnitOfWork();
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
        }
        [Fact]
        public async Task GetCommonQuestionList_Valid()
        {
            var handler = new GetCommonQuestionListRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new GetCommonQuestionListRequest(), CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            
            
            result.Errors.ShouldBeNull();
        }
    }
}

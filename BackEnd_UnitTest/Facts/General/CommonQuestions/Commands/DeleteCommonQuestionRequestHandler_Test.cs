using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Commands;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.CommonQuestions.Commands
{
    public class DeleteCommonQuestionRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public DeleteCommonQuestionRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task DeleteCommonQuestion_Valid()
        {
            var handler = new DeleteCommonQuestionRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeleteCommonQuestionRequest() { Id = 1 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);


        }

        [Fact]
        public async Task DeleteCommonQuestion_NotFound_InValid()
        {
            var handler = new DeleteCommonQuestionRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new DeleteCommonQuestionRequest() { Id = 40 }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);


        }
    }
}

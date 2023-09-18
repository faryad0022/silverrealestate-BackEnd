using Application.Const.Response;
using Application.Contract.Persistence;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Models.General.CommonQuestions;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.General.CommonQuestions.Commands
{
    public class CreateCommonQuestionRequestHandler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public CreateCommonQuestionRequestHandler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task CreateCommonQuestion_Valid()
        {
            var handler = new CreateCommonQuestionRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateCommonQuestionRequest() { createCommonQuestionDTO = CommonQuestionModelGenerator.createCommonQuestionDTO }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);

            result.Errors.ShouldBeNull();


        }
        [Fact]
        public async Task CreateCommonQuestion_Validation_InValid()
        {
            var handler = new CreateCommonQuestionRequestHandler(_mapper, _mock.Object);
            var result = await handler.Handle(new CreateCommonQuestionRequest() { createCommonQuestionDTO = CommonQuestionModelGenerator.createCommonQuestionDTO_Invalid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);

            result.Errors.ShouldNotBeNull();


        }
    }
}

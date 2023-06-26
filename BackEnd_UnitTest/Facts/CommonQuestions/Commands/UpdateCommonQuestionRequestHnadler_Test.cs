using Application.Const.Response;
using Application.Contract.Persistence;
using Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Commands;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command;
using Application.Profiles;
using AutoMapper;
using BackEnd_UnitTest.Mocks;
using BackEnd_UnitTest.Mocks.Models.CommonQuestions;
using Moq;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BackEnd_UnitTest.Facts.CommonQuestions.Commands
{
    public class UpdateCommonQuestionRequestHnadler_Test
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitofWork> _mock;
        public UpdateCommonQuestionRequestHnadler_Test()
        {
            var mappConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = mappConfig.CreateMapper();
            _mock = MockUniOfWork.GetMockUnitOfWork();
        }
        [Fact]
        public async Task UpdateCommonQuestion_Valid()
        {
            var handler = new UpdateCommonQuestionRequestHnadler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateCommonQuestionRequest() { updateCommonQuestionDTO = CommonQuestionModelGenerator.updateCommonQuestionDTO_Valid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.Success);
            
            
        }
        [Fact]
        public async Task UpdateCommonQuestion_Validation_InValid()
        {
            var handler = new UpdateCommonQuestionRequestHnadler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateCommonQuestionRequest() { updateCommonQuestionDTO = CommonQuestionModelGenerator.updateCommonQuestionDTO_Validation_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.ValidationError);
            result.Errors.ShouldNotBeNull();
            
            
        }

        [Fact]
        public async Task UpdateCommonQuestion_NotFound_InValid()
        {
            var handler = new UpdateCommonQuestionRequestHnadler(_mapper, _mock.Object);
            var result = await handler.Handle(new UpdateCommonQuestionRequest() { updateCommonQuestionDTO = CommonQuestionModelGenerator.updateCommonQuestionDTO_NotFound_InValid }, CancellationToken.None);

            result.Status.ShouldBe(StatusMessage.NotFound);
            result.Errors.ShouldBeNull();
            
            
        }
    }
}

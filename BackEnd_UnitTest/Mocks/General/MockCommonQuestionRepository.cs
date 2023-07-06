using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using BackEnd_UnitTest.Mocks.Models.CommonQuestions;
using Domain.Entities.GeneralSiteInformation;
using Moq;
using System.Linq;

namespace BackEnd_UnitTest.Mocks.General
{
    public static class MockCommonQuestionRepository
    {
        public static Mock<ICommonQuestionRepository> GetCommonQuestionRepository()
        {
            var _mock = new Mock<ICommonQuestionRepository>();
            var commonQuestionList = CommonQuestionModelGenerator.listCommonQuestion;

            _mock.Setup(m => m.GetEntityAsync(It.IsAny<long>()))
                .ReturnsAsync((long id) => commonQuestionList.FirstOrDefault(x => x.Id == id));
            _mock.Setup(m => m.GetAllAsync())
                .ReturnsAsync(commonQuestionList.Where(t => !t.IsDelete).ToList());
            _mock.Setup(m => m.AddEntityAsync(It.IsAny<CommonQuestion>()))
                .ReturnsAsync((CommonQuestion common) =>
                {
                    commonQuestionList.Add(common);
                    return common;
                });
            _mock.Setup(m => m.UpdateEntity(It.IsAny<CommonQuestion>())).Callback(() => { return; });

            return _mock;
        }
    }
}

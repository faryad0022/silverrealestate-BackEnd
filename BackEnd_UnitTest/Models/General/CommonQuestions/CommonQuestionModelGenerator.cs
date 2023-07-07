using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Models.General.CommonQuestions
{
    public static class CommonQuestionModelGenerator
    {
        public static List<CommonQuestion> listCommonQuestion = new()
        {
            new CommonQuestion
            {
                Id = 1,
                Question="What is cyprus",
                Answer="Beautifull place",
                IsSelected = true
            },
              new CommonQuestion
            {
                Id = 2,
                Question="What is cyprus asdfsfgsf",
                Answer="Beautifull place asdfsgsdfg",
                IsSelected = false
            },
        };

        public static CreateCommonQuestionDTO createCommonQuestionDTO = new CreateCommonQuestionDTO
        {
            Answer = "adfasdfadfafasdasdgasdgasga",
            Question = "adfadfasdferfqerfw34023409823409834"
        };
        public static CreateCommonQuestionDTO createCommonQuestionDTO_Invalid = new CreateCommonQuestionDTO
        {
            Question = "adfadfasdferfqerfw34023409823409834"
        };

        public static UpdateCommonQuestionDTO updateCommonQuestionDTO_Valid = new UpdateCommonQuestionDTO
        {
            Id = 1,
            Question = "What is cyprus",
            Answer = "Beautifull place",
        };
        public static UpdateCommonQuestionDTO updateCommonQuestionDTO_Validation_InValid = new UpdateCommonQuestionDTO
        {
            Id = 1,
            Answer = "Beautifull place",
        };
        public static UpdateCommonQuestionDTO updateCommonQuestionDTO_NotFound_InValid = new UpdateCommonQuestionDTO
        {
            Id = 10,
            Question = "What is cyprus",
            Answer = "Beautifull place",
        };
    }
}

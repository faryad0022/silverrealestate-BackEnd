namespace Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions
{
    public class CreateCommonQuestionDTO : ICommonQuestionDTO
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}

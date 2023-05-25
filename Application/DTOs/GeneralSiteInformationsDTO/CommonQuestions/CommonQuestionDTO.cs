using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions
{
    public class CommonQuestionDTO : BaseEntityDTO, ICommonQuestionDTO
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}

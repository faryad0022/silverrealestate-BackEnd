using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions
{
    public class UpdateCommonQuestionDTO : BaseEntityDTO, ICommonQuestionDTO
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}

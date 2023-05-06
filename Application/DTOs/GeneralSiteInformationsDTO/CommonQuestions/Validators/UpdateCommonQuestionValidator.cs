using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions.Validators
{
    public class UpdateCommonQuestionValidator : AbstractValidator<UpdateCommonQuestionDTO>
    {
        public UpdateCommonQuestionValidator()
        {
            Include(new ICommonQuestionValidator());
        }
    }
}

using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions.Validators
{
    public class CreateCommonQuestionValidator : AbstractValidator<CreateCommonQuestionDTO>
    {
        public CreateCommonQuestionValidator()
        {
            Include(new ICommonQuestionValidator());
        }
    }
}

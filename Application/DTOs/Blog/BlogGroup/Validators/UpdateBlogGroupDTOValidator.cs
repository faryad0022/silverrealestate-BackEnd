using FluentValidation;

namespace Application.DTOs.Blog.BlogGroup.Validators
{
    public class UpdateBlogGroupDTOValidator:AbstractValidator<UpdateBlogGroupDTO>
    {
        public UpdateBlogGroupDTOValidator()
        {
            Include(new IBlogGroupValidator());
        }
    }
}

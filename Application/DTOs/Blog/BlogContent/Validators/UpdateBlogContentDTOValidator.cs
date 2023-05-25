using Application.Const.Validator;
using Application.Contract.Persistance.EntitiesRepository.Blog;
using FluentValidation;

namespace Application.DTOs.Blog.BlogContent.Validators
{
    public class UpdateBlogContentDTOValidator : AbstractValidator<UpdateBlogContentDTO>
    {
        private readonly IBlogContentRepository _blogContentRepository;

        public UpdateBlogContentDTOValidator(IBlogContentRepository blogContentRepository)
        {
            _blogContentRepository = blogContentRepository;

            Include(new IBlogContentValidator());
            RuleFor(x => x.Id)
                .MustAsync(async (id, token) =>
                {
                    var x = await _blogContentRepository.ExistAsync(id);
                    return x;
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}

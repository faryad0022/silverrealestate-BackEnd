using Application.Const.Validator;
using Application.Contract.Persistance.EntitiesRepository.Blog;
using FluentValidation;

namespace Application.DTOs.Blog.BlogContent.Validators
{
    public class CreateBlogContantDTOValidator : AbstractValidator<CreateBlogContentDTO>
    {
        private readonly IBlogGroupRepository _blogGroupRepository;

        public CreateBlogContantDTOValidator(IBlogGroupRepository blogGroupRepository)
        {
            _blogGroupRepository = blogGroupRepository;

            Include(new IBlogContentValidator());
            RuleFor(x => x.BlogGroupId)
                .MustAsync(async (id, token) => await _blogGroupRepository.ExistAsync(id))
                .WithMessage(ValidatorMessages.NotExist);
        }
    }
}

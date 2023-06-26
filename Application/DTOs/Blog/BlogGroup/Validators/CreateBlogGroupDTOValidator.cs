using Application.Const.Response;
using Application.Contract.Persistance.EntitiesRepository.Blog;
using FluentValidation;

namespace Application.DTOs.Blog.BlogGroup.Validators
{
    public class CreateBlogGroupDTOValidator : AbstractValidator<CreateBlogGroupDTO>
    {
        private readonly IBlogGroupRepository _blogGroupRepository;

        public CreateBlogGroupDTOValidator(IBlogGroupRepository blogGroupRepository)
        {
            _blogGroupRepository = blogGroupRepository;
            Include(new IBlogGroupValidator());
            RuleFor(x => x.Name)
                .MustAsync(async (name, token) =>
                {
                    var blogGroup = await _blogGroupRepository.IsDuplicate(name);
                    return !blogGroup;
                }).WithMessage(ValidatorMessages.Duplicate);
        }
    }
}

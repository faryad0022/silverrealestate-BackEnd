using Application.Const.PathUtility;
using Application.Const.Response;
using Application.Contract.Infrastructure;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Blog.BlogContent.Validators;
using Application.Extensions;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using AutoMapper;
using Domain.Entities.Blog;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Commands.BlogcontentCommands
{
    public class CreateBlogContentRequestHandler : IRequestHandler<CreateBlogContentRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        private readonly IUnitofWork _unitofWork;

        public CreateBlogContentRequestHandler(IMapper mapper, IEmailSender emailSender, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _emailSender = emailSender;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(CreateBlogContentRequest request, CancellationToken cancellationToken)
        {
            #region Upload Image
            var createdImageName = ImageUploaderExtensions.UploadImage(
                request.createBlogContentDTO.ImageName,
                PathTools.BlogServerPath
                );
            if (string.IsNullOrEmpty(createdImageName))
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.UploadError,
                    null
                    );
            #endregion

            var blogContent = _mapper.Map<BlogContent>(request.createBlogContentDTO);
            blogContent.ImageName = createdImageName;
            #region Validator
            var validator = new CreateBlogContantDTOValidator(_unitofWork.BlogGroupRepository);
            var validatorResult = await validator.ValidateAsync(request.createBlogContentDTO);
            if (!validatorResult.IsValid)
            {
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            }
            #endregion


            blogContent = await _unitofWork.BlogContentRepository.AddEntityAsync(blogContent);

            //var email = new Email
            //{
            //    To = "mahancomputer49@gmail.com",
            //    Subject = "Submitted",
            //    Body = $"New blog by Id {blogContent.Id} and title {blogContent.Title} is created"
            //};
            //try
            //{
            //    await _emailSender.SendEmailAsync(email);

            //}
            //catch (Exception e)
            //{

            //    throw e;
            //}
            await _unitofWork.SaveChangesAsync();
            var createdBlogContentDTO = _mapper.Map<BlogContentDTO>(blogContent);
            return ResponseResultDTO.SetResult(createdBlogContentDTO, StatusMessage.Success, null);

        }
    }
}

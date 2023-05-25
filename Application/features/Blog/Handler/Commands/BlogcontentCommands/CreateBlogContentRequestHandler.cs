using Application.Const.Response;
using Application.Contract.Infrastructure;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Blog.BlogContent.Validators;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using Application.Models;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.Blog;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Commands.BlogcontentCommands
{
    public class CreateBlogContentRequestHandler : IRequestHandler<CreateBlogContentRequest, ReturnData<CreateBlogContentDTO>>
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
        public async Task<ReturnData<CreateBlogContentDTO>> Handle(CreateBlogContentRequest request, CancellationToken cancellationToken)
        {

            #region Validator
            var validator = new CreateBlogContantDTOValidator(_unitofWork.BlogGroupRepository);
            var validatorResult = await validator.ValidateAsync(request.createBlogContentDTO);
            if (!validatorResult.IsValid)
            {
                return FillRetuenData<CreateBlogContentDTO>.FillByEntity(null, ResponseStatus.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            }
            #endregion

            var blogContent = _mapper.Map<BlogContent>(request.createBlogContentDTO);

            blogContent = await _unitofWork.BlogContentRepository.AddEntityAsync(blogContent);

            var email = new Email
            {
                To = "mahancomputer49@gmail.com",
                Subject = "Submitted",
                Body = $"New blog by Id {blogContent.Id} and title {blogContent.Title} is created"
            };
            try
            {
                await _emailSender.SendEmailAsync(email);

            }
            catch (Exception e)
            {

                throw e;
            }
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<CreateBlogContentDTO>.FillByEntity(request.createBlogContentDTO, ResponseStatus.Success, null);

        }
    }
}

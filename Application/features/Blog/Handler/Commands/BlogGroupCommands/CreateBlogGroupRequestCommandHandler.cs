using Application.Const.Response;
using Application.Contract.Infrastructure;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogGroup;
using Application.DTOs.Blog.BlogGroup.Validators;
using Application.features.Blog.Request.Commands.BlogGroupCommands;
using Application.Models;
using AutoMapper;
using Domain.Entities.Blog;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Commands.BlogGroupCommands
{
    public class CreateBlogGroupRequestCommandHandler : IRequestHandler<CreateBlogGroupRequestCommand, ResponseResultDTO>
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;

        public CreateBlogGroupRequestCommandHandler(IEmailSender emailSender, IUnitofWork unitofWork, IMapper mapper)
        {
            _emailSender = emailSender;
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public async Task<ResponseResultDTO> Handle(CreateBlogGroupRequestCommand request, CancellationToken cancellationToken)
        {
            var blogGroup = _mapper.Map<BlogGroup>(request.createBlogGroupDTO);

            #region Validations
            var validator = new CreateBlogGroupDTOValidator(_unitofWork.BlogGroupRepository);
            var validatorResult = await validator.ValidateAsync(request.createBlogGroupDTO);
            if (!validatorResult.IsValid)
            {
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());

            }
            #endregion

            #region Add BlogGroup
            blogGroup = await _unitofWork.BlogGroupRepository.AddEntityAsync(blogGroup);
            await _unitofWork.SaveChangesAsync();
            try
            {


                var email = new Email
                {
                    To = "asdadfwefwf",
                    Body = $"Your leave request for " +
                    $"has been submitted successfully.",
                    Subject = "Leave Request Submitted"
                };

                await _emailSender.SendEmailAsync(email);
            }
            catch (Exception ex)
            {
                //// Log or handle error, but don't throw...
            }

            return ResponseResultDTO.SetResult(request.createBlogGroupDTO, StatusMessage.Success, null);
            #endregion

        }
    }
}

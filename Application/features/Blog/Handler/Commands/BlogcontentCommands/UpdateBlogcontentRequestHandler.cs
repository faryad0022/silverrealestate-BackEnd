using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Blog.BlogContent.Validators;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using AutoMapper;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Commands.BlogcontentCommands
{
    public class UpdateBlogcontentRequestHandler : IRequestHandler<UpdateBlogcontentRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateBlogcontentRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(UpdateBlogcontentRequest request, CancellationToken cancellationToken)
        {
            var blogContent = await _unitofWork.BlogContentRepository.GetEntityAsync(request.Id);

            if (blogContent is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);

            if (request.updateBlogContentDTO != null)
            {
                #region Validation
                var validator = new UpdateBlogContentDTOValidator(_unitofWork.BlogContentRepository);
                var validatorResult = await validator.ValidateAsync(request.updateBlogContentDTO);
                if (!validatorResult.IsValid)
                {
                    return ResponseResultDTO.SetResult(request.updateBlogContentDTO, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
                }
                #endregion

                _mapper.Map(request.updateBlogContentDTO, blogContent);
                _unitofWork.BlogContentRepository.UpdateEntity(blogContent);
            }
            else if (request.changeBlogContentStatusDTO != null)
            {
                await _unitofWork.BlogContentRepository.ChangeBlogContentStatus(blogContent);

            }
            else if (request.changeBlogContentIsSelected != null)
            {
                await _unitofWork.BlogContentRepository.ChangeBlogContentIsSelected(blogContent);

            }
            await _unitofWork.SaveChangesAsync();

            return ResponseResultDTO.SetResult(null, StatusMessage.Success, null);
        }
    }
}

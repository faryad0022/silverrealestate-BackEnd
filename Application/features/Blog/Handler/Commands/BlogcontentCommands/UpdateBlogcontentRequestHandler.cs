using Application.Const.PathUtility;
using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Blog.BlogContent.Validators;
using Application.Extensions;
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
            var blogContent = await _unitofWork.BlogContentRepository.GetEntityAsync(request.updateBlogContentDTO.Id);

            if (blogContent is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            #region Upload Image
            if (request.updateBlogContentDTO.ImageName != "")
            {
                var createdImageName = ImageUploaderExtensions.UploadImage(request.updateBlogContentDTO.ImageName, PathTools.BlogServerPath, blogContent.ImageName);
                if (string.IsNullOrEmpty(createdImageName))
                    return ResponseResultDTO.SetResult(null, StatusMessage.UploadError, null);
                request.updateBlogContentDTO.ImageName = createdImageName;
            }
            else
            {
                request.updateBlogContentDTO.ImageName = blogContent.ImageName;

            }

            #endregion

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


            await _unitofWork.SaveChangesAsync();
            var updatedDTO = _mapper.Map<BlogContentDTO>(await _unitofWork.BlogContentRepository.GetBlogContentWithDetailsAsync(request.updateBlogContentDTO.Id));
            return ResponseResultDTO.SetResult(updatedDTO, StatusMessage.Success, null);
        }
    }
}

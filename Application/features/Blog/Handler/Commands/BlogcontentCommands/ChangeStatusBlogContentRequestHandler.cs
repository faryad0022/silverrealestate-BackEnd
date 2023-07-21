using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Commands.BlogcontentCommands
{
    public class ChangeStatusBlogContentRequestHandler : IRequestHandler<ChangeStatusBlogContentRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeStatusBlogContentRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(ChangeStatusBlogContentRequest request, CancellationToken cancellationToken)
        {
            var blogContent = await _unitofWork.BlogContentRepository.GetBlogContentWithDetailsAsync(request.Id);
            if (blogContent is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            blogContent.IsSelected = !blogContent.IsSelected;
            _unitofWork.BlogContentRepository.UpdateEntity(blogContent);
            await _unitofWork.SaveChangesAsync();
            var updatedBlogContentDTO = _mapper.Map<BlogContentDTO>(blogContent);
            return ResponseResultDTO.SetResult(updatedBlogContentDTO, StatusMessage.Success, null);
            throw new NotImplementedException();
        }
    }
}

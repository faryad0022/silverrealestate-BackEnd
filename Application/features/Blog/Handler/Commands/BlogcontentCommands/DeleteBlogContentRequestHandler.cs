using Application.Const.Response;
using Application.Contract.Persistance.EntitiesRepository.Blog;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Commands.BlogcontentCommands
{
    public class DeleteBlogContentRequestHandler : IRequestHandler<DeleteBlogContentRequest, ReturnData<BlogContentDTO>>
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public DeleteBlogContentRequestHandler(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public async Task<ReturnData<BlogContentDTO>> Handle(DeleteBlogContentRequest request, CancellationToken cancellationToken)
        {
            var blogContent = await _unitofWork.BlogContentRepository.GetEntityAsync(request.blogContentDTO.Id);
            if (blogContent is null)
                return FillRetuenData<BlogContentDTO>.FillByEntity(null, ResponseStatus.NotFound, null);
            _unitofWork.BlogContentRepository.DeleteEntityAsync(blogContent);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<BlogContentDTO>.FillByEntity(_mapper.Map<BlogContentDTO>(blogContent), ResponseStatus.Success, null);

        }
    }
}

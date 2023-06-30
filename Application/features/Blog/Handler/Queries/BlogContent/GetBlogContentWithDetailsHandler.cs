using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Queries.BlogContent;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Queries.BlogContent
{
    public class GetBlogContentWithDetailsHandler : IRequestHandler<GetBlogContentWithDetails, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBlogContentWithDetailsHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetBlogContentWithDetails request, CancellationToken cancellationToken)
        {
            var blogContent = await _unitofWork.BlogContentRepository.GetBlogContentWithDetailsAsync(request.blogContentId);
            if (blogContent is null)
                return ResponseResultDTO.SetResult(
                null,
                StatusMessage.NotFound,
                null);
            return ResponseResultDTO.SetResult(
                _mapper.Map<BlogContentDTO>(blogContent),
                StatusMessage.Success,
                null);
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Queries.BlogContent;
using Application.Models.FilterModels;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Queries.BlogContent
{
    public class GetBlogContentByFilterRequestHandler : IRequestHandler<GetBlogContentByFilterRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBlogContentByFilterRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(GetBlogContentByFilterRequest request, CancellationToken cancellationToken)
        {
            var filter = _mapper.Map<FilterBlogContent>(request.filter);
            var blogContent = await _unitofWork.BlogContentRepository.FilterBlogContent(filter);
            var filterBlogContentDTO = _mapper.Map<FilterBlogContentDTO>(blogContent);
            if (blogContent.BlogContentList is null || blogContent.BlogContentList.Count == 0)
                return ResponseResult.SetResult(filterBlogContentDTO, StatusMessage.NoContent, null);

            return ResponseResult.SetResult(filterBlogContentDTO, StatusMessage.Success, null);
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Filters;
using Application.features.Blog.Request.Queries.BlogContent;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Queries.BlogContent
{
    public class GetBlogContentByFilterRequestHandler : IRequestHandler<GetBlogContentByFilterRequest, ReturnData<FilterBlogContentDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBlogContentByFilterRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<FilterBlogContentDTO>> Handle(GetBlogContentByFilterRequest request, CancellationToken cancellationToken)
        {
            var blogContent = await _unitofWork.BlogContentRepository.FilterBlogContent(request.filter);
            if (blogContent.BlogContentList is null || blogContent.BlogContentList.Count == 0)
                return FillRetuenData<FilterBlogContentDTO>.FillByEntity(null, ResponseStatus.NotFound, null);

            var filterBlogContentDTO = _mapper.Map<FilterBlogContentDTO>(blogContent);
            return FillRetuenData<FilterBlogContentDTO>.FillByEntity(filterBlogContentDTO, ResponseStatus.Success, null);
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Queries.BlogContent;
using Application.Models.FilterModels;
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
            var filterDTO = _mapper.Map<FilterBlogContent>(request.filter);
            var blogContent = await _unitofWork.BlogContentRepository.FilterBlogContent(filterDTO);
            var filterBlogContentDTO = _mapper.Map<FilterBlogContentDTO>(blogContent);
            if (blogContent.BlogContentList is null || blogContent.BlogContentList.Count == 0)
                return SetReturnData<FilterBlogContentDTO>.SetTEntity(filterBlogContentDTO, ResponseStatus.NoContent, null);

            return SetReturnData<FilterBlogContentDTO>.SetTEntity(filterBlogContentDTO, ResponseStatus.Success, null);
        }
    }
}

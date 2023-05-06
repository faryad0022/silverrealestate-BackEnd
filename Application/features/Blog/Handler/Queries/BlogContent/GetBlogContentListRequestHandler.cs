using Application.Const.Response;
using Application.Contract.Persistance.EntitiesRepository.Blog;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Queries.BlogContent;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Queries.BlogContent
{
    public class GetBlogContentListRequestHandler : IRequestHandler<GetBlogContentListRequest, ReturnData<BlogContentListDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBlogContentListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<BlogContentListDTO>> Handle(GetBlogContentListRequest request, CancellationToken cancellationToken)
        {
            var blogContentList = await _unitofWork.BlogContentRepository.GetAllAsync();
            return FillRetuenData<BlogContentListDTO>.FillByListEntity(
                _mapper.Map<List<BlogContentListDTO>>(blogContentList),
                ResponseStatus.Success,
                null);
        }
    }
}

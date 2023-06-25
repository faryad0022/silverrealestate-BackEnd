using Application.Const.Response;
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
    public class GetBlogContentWithDetailsListRequestHandler : IRequestHandler<GetBlogContentWithDetailsListRequest, ReturnData<BlogContentDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBlogContentWithDetailsListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<BlogContentDTO>> Handle(GetBlogContentWithDetailsListRequest request, CancellationToken cancellationToken)
        {
            var blogContentWithDetails = await _unitofWork.BlogContentRepository.GetBlogContentWithDetailsListAsync();
            return SetReturnData<BlogContentDTO>.SetTEntities(
                _mapper.Map<List<BlogContentDTO>>(blogContentWithDetails),
                ResponseStatus.Success,
                null);
        }
    }
}

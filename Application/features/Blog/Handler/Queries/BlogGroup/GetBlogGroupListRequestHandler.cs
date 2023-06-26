using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogGroup;
using Application.features.Blog.Request.Queries.BlogGroup;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Queries.BlogGroup
{
    public class GetBlogGroupListRequestHandler : IRequestHandler<GetBlogGroupListRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBlogGroupListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(GetBlogGroupListRequest request, CancellationToken cancellationToken)
        {
            var blogGroupList = await _unitofWork.BlogGroupRepository.GetAllAsync();
            return ResponseResult.SetResult(
                            _mapper.Map<List<BlogGroupDTO>>(blogGroupList),
                            StatusMessage.Success,
                            null);
        }
    }
}

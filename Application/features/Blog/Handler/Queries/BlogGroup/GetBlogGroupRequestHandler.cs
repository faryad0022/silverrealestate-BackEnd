using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogGroup;
using Application.features.Blog.Request.Queries.BlogGroup;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Queries.BlogGroup
{
    public class GetBlogGroupRequestHandler : IRequestHandler<GetBlogGroupRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBlogGroupRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(GetBlogGroupRequest request, CancellationToken cancellationToken)
        {
            var blogGroup = await _unitofWork.BlogGroupRepository.GetEntityAsync(request.blogGroupId);
            if (blogGroup is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            return ResponseResult.SetResult(_mapper.Map<BlogGroupDTO>(blogGroup), StatusMessage.Success, null);
        }
    }
}

using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Queries.BlogContent;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Queries.BlogContent
{
    public class GetLatestBlogsRequestHandler : IRequestHandler<GetLatestBlogsRequest, ResponseResultDTO>
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public GetLatestBlogsRequestHandler(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        public async Task<ResponseResultDTO> Handle(GetLatestBlogsRequest request, CancellationToken cancellationToken)
        {
            var blogContentList = await _unitofWork.BlogContentRepository.GetBlogContentWithDetailsListAsync();
            blogContentList = blogContentList.Where(x=>x.IsSelected).OrderByDescending(d => d.LastUpdateDate).Take(5).ToList();
            return ResponseResultDTO.SetResult(
                _mapper.Map<List<BlogContentDTO>>(blogContentList),
                StatusMessage.Success,
                null);
        }
    }
}

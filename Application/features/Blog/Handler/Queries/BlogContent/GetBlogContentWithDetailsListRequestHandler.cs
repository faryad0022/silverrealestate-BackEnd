using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Queries.BlogContent;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Blog.Handler.Queries.BlogContent
{
    public class GetBlogContentWithDetailsListRequestHandler : IRequestHandler<GetBlogContentWithDetailsListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBlogContentWithDetailsListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetBlogContentWithDetailsListRequest request, CancellationToken cancellationToken)
        {
            var blogContentWithDetails = await _unitofWork.BlogContentRepository.GetBlogContentWithDetailsListAsync();
            return ResponseResultDTO.SetResult(
                _mapper.Map<List<BlogContentDTO>>(blogContentWithDetails),
                StatusMessage.Success,
                null);
        }
    }
}

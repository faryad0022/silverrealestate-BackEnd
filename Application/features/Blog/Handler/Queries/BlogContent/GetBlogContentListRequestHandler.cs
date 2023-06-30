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
    public class GetBlogContentListRequestHandler : IRequestHandler<GetBlogContentListRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBlogContentListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetBlogContentListRequest request, CancellationToken cancellationToken)
        {
            var blogContentList = await _unitofWork.BlogContentRepository.GetAllAsync();
            return ResponseResultDTO.SetResult(
                _mapper.Map<List<BlogContentListDTO>>(blogContentList),
                StatusMessage.Success,
                null);
        }
    }
}

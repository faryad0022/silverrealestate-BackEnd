using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Blog.BlogContent;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.DTOs.Project.PropertDTOs;
using Application.DTOs.Site;
using Application.features.Site.Request.Queries;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Site.Handler.Queries
{
    public class GetHomeDTOsRequestHandler : IRequestHandler<GetHomeDTOsRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetHomeDTOsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(GetHomeDTOsRequest request, CancellationToken cancellationToken)
        {
            var banners = await _unitofWork.BannerRepository.GetAllAsync();
            var properties = await _unitofWork.PropertyRepository.GetPropertyListWithDetails();
            var blog = await _unitofWork.BlogContentRepository.GetBlogContentWithDetailsListAsync();

            banners = banners.Where(x => x.IsSelected).ToList();
            properties = properties.Where(x => x.IsSelected).Take(5).ToList();
            blog = blog.Where(x => x.IsSelected).Take(5).ToList();
            var homeDTO = new HomeDTO()
            {
                BannerDTOs = _mapper.Map<List<BannerDTO>>(banners),
                LatestBlogContent = _mapper.Map<List<BlogContentDTO>>(blog),
                LatestProperty = _mapper.Map<List<PropertyDTO>>(properties)
            };

            return ResponseResultDTO.SetResult(homeDTO, StatusMessage.Success, null);
        }
    }
}

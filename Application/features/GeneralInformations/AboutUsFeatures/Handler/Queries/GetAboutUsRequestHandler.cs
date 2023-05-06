using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AboutUsFeatures.Handler.Queries
{
    public class GetAboutUsRequestHandler : IRequestHandler<GetAboutUsRequest, ReturnData<AboutUsDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetAboutUsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ReturnData<AboutUsDTO>> Handle(GetAboutUsRequest request, CancellationToken cancellationToken)
        {
            var aboutUs = await _unitofWork.AboutUsRepository.GetEntityAsync(request.Id);
            if (aboutUs is null)
                return FillRetuenData<AboutUsDTO>.FillByEntity(null, ResponseStatus.NotFound, null);
            return FillRetuenData<AboutUsDTO>.FillByEntity(_mapper.Map<AboutUsDTO>(aboutUs), ResponseStatus.Success, null);
        }
    }
}
